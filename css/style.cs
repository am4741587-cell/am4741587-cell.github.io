rm css/style.css
cat > css/style.css << 'EOF'
*,*::before,*::after{margin:0;padding:0;box-sizing:border-box}
:root{--negro:#0D0D0D;--carbon:#1A1A1A;--oro:#C9A84C;--oro-claro:#E8C97A;--blanco:#F5F2EC;--gris:#888;--fuente-titulo:'Playfair Display',Georgia,serif;--fuente-cuerpo:'Inter',system-ui,sans-serif;--max:1140px;--radio:2px}
html{scroll-behavior:smooth}
body{font-family:var(--fuente-cuerpo);background:var(--blanco);color:var(--negro);line-height:1.6}
.container{max-width:var(--max);margin:0 auto;padding:0 24px}
header{background:var(--negro);padding:0 32px;height:64px;display:flex;align-items:center;justify-content:space-between;position:sticky;top:0;z-index:200;border-bottom:1px solid #222}
.logo{display:flex;align-items:center;gap:8px}
.logo-text{font-family:var(--fuente-titulo);font-size:1.1rem;color:var(--blanco)}
.logo-text strong{color:var(--oro)}
nav a{color:#aaa;text-decoration:none;font-size:0.85rem;font-weight:500;letter-spacing:0.06em;text-transform:uppercase;margin-left:28px;transition:color 0.2s}
nav a:hover{color:var(--oro)}
.menu-toggle{display:none;background:none;border:none;color:white;font-size:1.4rem;cursor:pointer}
.mobile-nav{display:none;flex-direction:column;background:var(--carbon);padding:16px 24px;border-bottom:1px solid #333}
.mobile-nav.open{display:flex}
.mobile-nav a{color:#ccc;text-decoration:none;padding:10px 0;border-bottom:1px solid #333;font-size:0.95rem}
.hero{background:var(--negro);color:var(--blanco);padding:80px 32px 60px;position:relative;overflow:hidden}
.hero-eyebrow{font-size:0.75rem;font-weight:500;letter-spacing:0.18em;text-transform:uppercase;color:var(--oro);margin-bottom:20px}
.hero h1{font-family:var(--fuente-titulo);font-size:clamp(2.4rem,6vw,4.5rem);font-weight:900;line-height:1.05;margin-bottom:20px}
.hero h1 em{font-style:italic;color:var(--oro)}
.hero p{font-size:1.05rem;color:#aaa;max-width:520px;margin-bottom:36px;line-height:1.7}
.hero-content{max-width:var(--max);margin:0 auto}
.hero-ctas{display:flex;gap:14px;flex-wrap:wrap}
.btn-primary{background:var(--oro);color:var(--negro);padding:13px 28px;font-weight:700;font-size:0.9rem;text-decoration:none;border-radius:var(--radio);transition:background 0.2s}
.btn-primary:hover{background:var(--oro-claro)}
.btn-secondary{border:1px solid #444;color:#ccc;padding:13px 28px;font-size:0.9rem;text-decoration:none;border-radius:var(--radio);transition:all 0.2s}
.btn-secondary:hover{border-color:var(--oro);color:var(--oro)}
.hero-stats{max-width:var(--max);margin:56px auto 0;display:flex;gap:48px;border-top:1px solid #222;padding-top:32px}
.stat{display:flex;flex-direction:column}
.stat-num{font-family:var(--fuente-titulo);font-size:2.2rem;font-weight:700;color:var(--oro);line-height:1}
.stat-label{font-size:0.78rem;color:#666;letter-spacing:0.08em;text-transform:uppercase;margin-top:4px}
.ad-wrap{max-width:900px;margin:32px auto;padding:0 24px;text-align:center}
.ad-label{font-size:0.65rem;color:#bbb;letter-spacing:0.1em;text-transform:uppercase;margin-bottom:6px}
.ad-mid{margin:48px auto}
.section-header{margin-bottom:36px}
.section-eyebrow{font-size:0.72rem;font-weight:600;letter-spacing:0.16em;text-transform:uppercase;color:var(--oro);margin-bottom:10px}
.section-header h2{font-family:var(--fuente-titulo);font-size:clamp(1.6rem,3vw,2.4rem);font-weight:700;color:var(--negro);border-left:3px solid var(--oro);padding-left:14px;line-height:1.2}
.regiones{background:var(--carbon);padding:40px 0}
.regiones .section-header h2{color:var(--blanco)}
.region-tabs{display:flex;gap:10px;flex-wrap:wrap}
.tab{padding:8px 20px;border:1px solid #444;background:transparent;color:#aaa;border-radius:20px;cursor:pointer;font-size:0.85rem;transition:all 0.2s}
.tab:hover,.tab.active{background:var(--oro);color:var(--negro);border-color:var(--oro);font-weight:600}
.lideres-section{padding:64px 0}
.grid{display:grid;grid-template-columns:repeat(auto-fill,minmax(300px,1fr));gap:24px}
.card{background:white;border:1px solid #e8e8e8;border-radius:var(--radio);overflow:hidden;transition:transform 0.2s,box-shadow 0.2s;cursor:pointer}
.card:hover{transform:translateY(-4px);box-shadow:0 12px 32px rgba(0,0,0,0.1)}
.card-top{background:var(--carbon);padding:28px 20px 20px;display:flex;align-items:center;gap:16px}
.card-bandera{font-size:2.8rem;line-height:1}
.card-nombre{color:white}
.card-nombre h3{font-family:var(--fuente-titulo);font-size:1.15rem;font-weight:700;margin-bottom:2px}
.card-nombre .cargo{font-size:0.78rem;color:var(--oro)}
.card-body{padding:18px 20px;font-size:0.88rem;color:#444;line-height:1.65}
.card-politicas{padding:12px 20px 16px;display:flex;gap:6px;flex-wrap:wrap;border-top:1px solid #f0f0f0}
.politica-tag{background:#f5f2ec;border:1px solid #e0d9cc;padding:3px 10px;border-radius:20px;font-size:0.72rem;color:#555;font-weight:500}
.analisis-section{background:#f0ede6;padding:64px 0}
.articulos-grid{display:grid;grid-template-columns:repeat(auto-fill,minmax(320px,1fr));gap:24px}
.articulo{background:white;border-radius:var(--radio);padding:24px;border-left:3px solid var(--oro);transition:box-shadow 0.2s}
.articulo:hover{box-shadow:0 8px 24px rgba(0,0,0,0.08)}
.articulo-meta{display:flex;justify-content:space-between;align-items:center;margin-bottom:12px}
.articulo-fecha{font-size:0.75rem;color:var(--gris);letter-spacing:0.06em;text-transform:uppercase}
.articulo-region{font-size:0.72rem;background:var(--negro);color:var(--oro);padding:2px 8px;border-radius:2px;font-weight:600}
.articulo h3{font-family:var(--fuente-titulo);font-size:1.05rem;margin-bottom:10px;line-height:1.4}
.articulo p{font-size:0.87rem;color:#555;line-height:1.65;margin-bottom:14px}
.articulo-link{font-size:0.82rem;font-weight:600;color:var(--oro);text-decoration:none}
.newsletter{background:var(--negro);padding:80px 32px}
.newsletter-inner{max-width:var(--max);margin:0 auto;display:grid;grid-template-columns:1fr 1fr;gap:60px;align-items:center}
.newsletter-text h2{font-family:var(--fuente-titulo);font-size:clamp(1.6rem,3vw,2.2rem);font-weight:900;color:var(--blanco);line-height:1.2;margin-bottom:14px}
.newsletter-text p{color:#777;font-size:0.95rem;line-height:1.7}
.newsletter-form{display:flex;flex-direction:column;gap:12px}
.newsletter-form input{padding:14px 18px;background:#1a1a1a;border:1px solid #333;color:white;font-size:0.95rem;border-radius:var(--radio);outline:none;transition:border-color 0.2s}
.newsletter-form input:focus{border-color:var(--oro)}
.newsletter-form button{padding:14px 24px;background:var(--oro);color:var(--negro);font-weight:700;font-size:0.9rem;border:none;cursor:pointer;border-radius:var(--radio);transition:background 0.2s}
.newsletter-form button:hover{background:var(--oro-claro)}
#msg-suscripcion{font-size:0.85rem;color:#4caf50;min-height:20px}
footer{background:#080808;color:#555;font-size:0.85rem}
.footer-inner{max-width:var(--max);margin:0 auto;padding:40px 24px 24px;display:flex;justify-content:space-between;align-items:flex-start;gap:32px;flex-wrap:wrap}
.footer-brand p{color:#444;margin-top:8px;font-size:0.82rem}
.footer-links{display:flex;gap:20px;flex-wrap:wrap;padding-top:4px}
.footer-links a{color:#444;text-decoration:none;transition:color 0.2s}
.footer-links a:hover{color:var(--oro)}
.footer-bottom{border-top:1px solid #111;text-align:center;padding:16px 24px;color:#333;font-size:0.78rem}
@media(max-width:768px){nav{display:none}.menu-toggle{display:block}.hero{padding:56px 20px 40px}.hero-stats{gap:28px;flex-wrap:wrap}.newsletter-inner{grid-template-columns:1fr;gap:32px}.footer-inner{flex-direction:column}}
@media(max-width:480px){.grid{grid-template-columns:1fr}.articulos-grid{grid-template-columns:1fr}.region-tabs{gap:8px}}
EOF
