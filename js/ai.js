const PROXY_URL = "https://groq-proxy-mj3y.onrender.com/api/consulta";

async function buscarLider(consulta) {
  if (!consulta.trim()) {
    document.getElementById('ai-resultado').innerHTML = '<p style="color:#e74c3c">Escribe un nombre.</p>';
    return;
  }
  const resultado = document.getElementById('ai-resultado');
  resultado.innerHTML = '<p class="ai-cargando">Buscando con IA...</p>';
  try {
    const response = await fetch(PROXY_URL, {
      method: "POST",
      headers: {"Content-Type": "application/json"},
      body: JSON.stringify({
        prompt: 'Informacion sobre el lider politico: "' + consulta + '". Responde SOLO en JSON sin markdown ni texto adicional: {"nombre":"nombre completo","pais":"pais","cargo":"cargo actual","bandera":"emoji bandera","region":"america o europa o asia o africa o oceania","resumen":"2 lineas sobre su gobierno","politicas":["politica 1","politica 2","politica 3"]}',
        conBusqueda: false
      })
    });
    const data = await response.json();
    if (!data.contenido) throw new Error('Sin respuesta del proxy');
    const clean = data.contenido.replace(/```json|```/g,'').trim();
    const lider = JSON.parse(clean);
    resultado.innerHTML =
      '<div class="card ai-card">' +
        '<div class="card-top">' +
          '<div class="card-bandera">' + lider.bandera + '</div>' +
          '<div class="card-nombre">' +
            '<h3>' + lider.nombre + '</h3>' +
            '<div class="cargo">' + lider.cargo + ' — ' + lider.pais + '</div>' +
          '</div>' +
        '</div>' +
        '<div class="card-body">' + lider.resumen + '</div>' +
        '<div class="card-politicas">' + lider.politicas.map(function(p){ return '<span class="politica-tag">' + p + '</span>'; }).join('') + '</div>' +
        '<div style="padding:12px 20px">' +
          '<button onclick="agregarLider(' + JSON.stringify(lider) + ')" style="background:#C9A84C;border:none;padding:8px 16px;cursor:pointer;border-radius:2px;font-weight:700;color:#000">+ Agregar al sitio</button>' +
        '</div>' +
      '</div>';
  } catch(e) {
    resultado.innerHTML = '<p style="color:#e74c3c">Error al buscar. Intenta de nuevo.</p>';
    console.error(e);
  }
}

function agregarLider(lider) {
  lideres.push(lider);
  renderLideres(lideres);
  document.getElementById('ai-resultado').innerHTML = '<p style="color:#4caf50;padding:12px 0">Lider agregado!</p>';
  document.getElementById('lideres').scrollIntoView({behavior:'smooth'});
}
