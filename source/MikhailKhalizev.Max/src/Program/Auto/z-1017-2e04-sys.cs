using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2e04-957724ef")]
        public void /* sys */ Method_1017_2e04()
        {
            ii(0x1017_2e04, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_2e05, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_2e06, 1); pushd(edx);                             /* push edx */
            ii(0x1017_2e07, 1); pushd(esi);                             /* push esi */
            ii(0x1017_2e08, 1); pushd(edi);                             /* push edi */
            ii(0x1017_2e09, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_2e0c, 6); mov(bl, memb_a32[ds, 0x101b_e1f2]);     /* mov bl, [0x101be1f2] */
            ii(0x1017_2e12, 7); cmp(memd_a32[ds, 0x101b_e85c], 0);      /* cmp dword [0x101be85c], 0x0 */
            ii(0x1017_2e19, 3); setz(dl);                               /* setz dl */
            ii(0x1017_2e1c, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_2e22, 2); if(jzd(0x1017_2e78, 0x54)) goto l_0x1017_2e78; /* jz 0x10172e78 */
            ii(0x1017_2e24, 6); mov(esi, memd_a32[ds, 0x101b_e858]);    /* mov esi, [0x101be858] */
            ii(0x1017_2e2a, 6); cmp(esi, 0xfff);                        /* cmp esi, 0xfff */
            ii(0x1017_2e30, 3); setz(dl);                               /* setz dl */
            ii(0x1017_2e33, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_2e39, 2); if(jnzd(0x1017_2e78, 0x3d)) goto l_0x1017_2e78; /* jnz 0x10172e78 */
            ii(0x1017_2e3b, 7); lea(edx, esi * 4 + 0);                  /* lea edx, [esi*4] */
            ii(0x1017_2e42, 2); sub(edx, esi);                          /* sub edx, esi */
            ii(0x1017_2e44, 7); lea(ecx, edx * 8 + 0);                  /* lea ecx, [edx*8] */
            ii(0x1017_2e4b, 6); mov(edx, memd_a32[ds, 0x101b_e854]);    /* mov edx, [0x101be854] */
            ii(0x1017_2e51, 2); add(edx, ecx);                          /* add edx, ecx */
            ii(0x1017_2e53, 6); mov(memd_a32[ds, edx], 0x2);            /* mov dword [edx], 0x2 */
            ii(0x1017_2e59, 6); mov(ecx, memd_a32[ds, 0x101b_e860]);    /* mov ecx, [0x101be860] */
            ii(0x1017_2e5f, 4); mov(memw_a32[ds, edx + 0xc], ax);       /* mov [edx+0xc], ax */
            ii(0x1017_2e63, 3); lea(edi, esi + 0x1);                    /* lea edi, [esi+0x1] */
            ii(0x1017_2e66, 3); mov(memd_a32[ds, edx + 0x4], ecx);      /* mov [edx+0x4], ecx */
            ii(0x1017_2e69, 6); mov(ecx, memd_a32[ds, 0x101b_e864]);    /* mov ecx, [0x101be864] */
            ii(0x1017_2e6f, 6); mov(memd_a32[ds, 0x101b_e858], edi);    /* mov [0x101be858], edi */
            ii(0x1017_2e75, 3); mov(memd_a32[ds, edx + 0x8], ecx);      /* mov [edx+0x8], ecx */
        l_0x1017_2e78:
            ii(0x1017_2e78, 4); cmp(ax, 0xe0);                          /* cmp ax, 0xe0 */
            ii(0x1017_2e7c, 2); if(jnzd(0x1017_2e8c, 0xe)) goto l_0x1017_2e8c; /* jnz 0x10172e8c */
            ii(0x1017_2e7e, 9); mov(memw_a32[ds, 0x101b_e1f0], 0x80);   /* mov word [0x101be1f0], 0x80 */
            ii(0x1017_2e87, 5); jmpd(0x1017_3091, 0x205); goto l_0x1017_3091; /* jmp 0x10173091 */
        l_0x1017_2e8c:
            ii(0x1017_2e8c, 2); test(al, 0x80);                         /* test al, 0x80 */
            ii(0x1017_2e8e, 2); if(jzd(0x1017_2e98, 0x8)) goto l_0x1017_2e98; /* jz 0x10172e98 */
            ii(0x1017_2e90, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1017_2e92, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_2e94, 2); and(al, 0x7f);                          /* and al, 0x7f */
            ii(0x1017_2e96, 2); jmpd(0x1017_2e9d, 0x5); goto l_0x1017_2e9d; /* jmp 0x10172e9d */
        l_0x1017_2e98:
            ii(0x1017_2e98, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
        l_0x1017_2e9d:
            ii(0x1017_2e9d, 7); add(ax, memw_a32[ds, 0x101b_e1f0]);     /* add ax, [0x101be1f0] */
            ii(0x1017_2ea4, 3); test(dx, dx);                           /* test dx, dx */
            ii(0x1017_2ea7, 2); if(jzd(0x1017_2ebc, 0x13)) goto l_0x1017_2ebc; /* jz 0x10172ebc */
            ii(0x1017_2ea9, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_2eab, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1017_2eae, 7); cmp(memb_a32[ds, ecx + 0x1020_9440], 0); /* cmp byte [ecx+0x10209440], 0x0 */
            ii(0x1017_2eb5, 2); if(jzd(0x1017_2ebc, 0x5)) goto l_0x1017_2ebc; /* jz 0x10172ebc */
            ii(0x1017_2eb7, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
        l_0x1017_2ebc:
            ii(0x1017_2ebc, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_2ebe, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1017_2ec1, 7); movzx(edi, memb_a32[ds, ecx + 0x1020_9440]); /* movzx edi, byte [ecx+0x10209440] */
            ii(0x1017_2ec8, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1017_2eca, 3); mov(si, dx);                            /* mov si, dx */
            ii(0x1017_2ecd, 2); cmp(edi, esi);                          /* cmp edi, esi */
            ii(0x1017_2ecf, 2); if(jzd(0x1017_2efc, 0x2b)) goto l_0x1017_2efc; /* jz 0x10172efc */
            ii(0x1017_2ed1, 6); mov(memb_a32[ds, ecx + 0x1020_9440], dl); /* mov [ecx+0x10209440], dl */
            ii(0x1017_2ed7, 4); cmp(dx, 0x1);                           /* cmp dx, 0x1 */
            ii(0x1017_2edb, 2); if(jnzd(0x1017_2eeb, 0xe)) goto l_0x1017_2eeb; /* jnz 0x10172eeb */
            ii(0x1017_2edd, 6); mov(cl, memb_a32[ds, 0x1020_954c]);     /* mov cl, [0x1020954c] */
            ii(0x1017_2ee3, 6); inc(memb_a32[ds, 0x1020_954c]);         /* inc byte [0x1020954c] */
            ii(0x1017_2ee9, 2); jmpd(0x1017_2efc, 0x11); goto l_0x1017_2efc; /* jmp 0x10172efc */
        l_0x1017_2eeb:
            ii(0x1017_2eeb, 3); test(dx, dx);                           /* test dx, dx */
            ii(0x1017_2eee, 2); if(jnzd(0x1017_2efc, 0xc)) goto l_0x1017_2efc; /* jnz 0x10172efc */
            ii(0x1017_2ef0, 6); mov(cl, memb_a32[ds, 0x1020_954c]);     /* mov cl, [0x1020954c] */
            ii(0x1017_2ef6, 6); dec(memb_a32[ds, 0x1020_954c]);         /* dec byte [0x1020954c] */
        l_0x1017_2efc:
            ii(0x1017_2efc, 6); mov(memb_a32[ds, 0x101b_e1f2], bl);     /* mov [0x101be1f2], bl */
            ii(0x1017_2f02, 3); test(dx, dx);                           /* test dx, dx */
            ii(0x1017_2f05, 6); if(jzd(0x1017_3082, 0x177)) goto l_0x1017_3082; /* jz 0x10173082 */
            ii(0x1017_2f0b, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1017_2f0d, 3); mov(memb_a32[ss, esp], al);             /* mov [esp], al */
            ii(0x1017_2f10, 5); mov(memw_a32[ss, esp + 0x2], si);       /* mov [esp+0x2], si */
            ii(0x1017_2f15, 4); cmp(ax, 0x3a);                          /* cmp ax, 0x3a */
            ii(0x1017_2f19, 2); if(jnzd(0x1017_2f65, 0x4a)) goto l_0x1017_2f65; /* jnz 0x10172f65 */
            ii(0x1017_2f1b, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1017_2f1d, 2); and(al, 0xfd);                          /* and al, 0xfd */
            ii(0x1017_2f1f, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1017_2f21, 3); or(ah, 0x2);                            /* or ah, 0x2 */
            ii(0x1017_2f24, 3); test(bl, 0x2);                          /* test bl, 0x2 */
            ii(0x1017_2f27, 2); if(jnzd(0x1017_2f3a, 0x11)) goto l_0x1017_2f3a; /* jnz 0x10172f3a */
            ii(0x1017_2f29, 3); test(bl, 0x2);                          /* test bl, 0x2 */
            ii(0x1017_2f2c, 2); if(jzd(0x1017_2f58, 0x2a)) goto l_0x1017_2f58; /* jz 0x10172f58 */
            ii(0x1017_2f2e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1017_2f30, 5); mov(memb_a32[ds, 0x101b_e1f2], al);     /* mov [0x101be1f2], al */
            ii(0x1017_2f35, 5); jmpd(0x1017_2fce, 0x94); goto l_0x1017_2fce; /* jmp 0x10172fce */
        l_0x1017_2f3a:
            ii(0x1017_2f3a, 7); cmp(memd_a32[ds, 0x1020_9540], 0);      /* cmp dword [0x10209540], 0x0 */
            ii(0x1017_2f41, 6); if(jnzd(0x1017_2fd3, 0x8c)) goto l_0x1017_2fd3; /* jnz 0x10172fd3 */
            ii(0x1017_2f47, 3); test(bl, 0x2);                          /* test bl, 0x2 */
            ii(0x1017_2f4a, 2); if(jzd(0x1017_2f58, 0xc)) goto l_0x1017_2f58; /* jz 0x10172f58 */
            ii(0x1017_2f4c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1017_2f4e, 5); mov(memb_a32[ds, 0x101b_e1f2], al);     /* mov [0x101be1f2], al */
            ii(0x1017_2f53, 5); jmpd(0x1017_2fce, 0x76); goto l_0x1017_2fce; /* jmp 0x10172fce */
        l_0x1017_2f58:
            ii(0x1017_2f58, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1017_2f5a, 6); mov(memb_a32[ds, 0x101b_e1f2], ah);     /* mov [0x101be1f2], ah */
            ii(0x1017_2f60, 5); jmpd(0x1017_2fce, 0x69); goto l_0x1017_2fce; /* jmp 0x10172fce */
        l_0x1017_2f65:
            ii(0x1017_2f65, 4); cmp(ax, 0x45);                          /* cmp ax, 0x45 */
            ii(0x1017_2f69, 2); if(jnzd(0x1017_2f80, 0x15)) goto l_0x1017_2f80; /* jnz 0x10172f80 */
            ii(0x1017_2f6b, 3); test(bl, 0x1);                          /* test bl, 0x1 */
            ii(0x1017_2f6e, 2); if(jzd(0x1017_2f75, 0x5)) goto l_0x1017_2f75; /* jz 0x10172f75 */
            ii(0x1017_2f70, 3); and(bl, 0xfe);                          /* and bl, 0xfe */
            ii(0x1017_2f73, 2); jmpd(0x1017_2f78, 0x3); goto l_0x1017_2f78; /* jmp 0x10172f78 */
        l_0x1017_2f75:
            ii(0x1017_2f75, 3); or(bl, 0x1);                            /* or bl, 0x1 */
        l_0x1017_2f78:
            ii(0x1017_2f78, 6); mov(memb_a32[ds, 0x101b_e1f2], bl);     /* mov [0x101be1f2], bl */
            ii(0x1017_2f7e, 2); jmpd(0x1017_2fce, 0x4e); goto l_0x1017_2fce; /* jmp 0x10172fce */
        l_0x1017_2f80:
            ii(0x1017_2f80, 4); cmp(ax, 0x46);                          /* cmp ax, 0x46 */
            ii(0x1017_2f84, 2); if(jnzd(0x1017_2f9b, 0x15)) goto l_0x1017_2f9b; /* jnz 0x10172f9b */
            ii(0x1017_2f86, 3); test(bl, 0x4);                          /* test bl, 0x4 */
            ii(0x1017_2f89, 2); if(jzd(0x1017_2f90, 0x5)) goto l_0x1017_2f90; /* jz 0x10172f90 */
            ii(0x1017_2f8b, 3); and(bl, 0xfb);                          /* and bl, 0xfb */
            ii(0x1017_2f8e, 2); jmpd(0x1017_2f93, 0x3); goto l_0x1017_2f93; /* jmp 0x10172f93 */
        l_0x1017_2f90:
            ii(0x1017_2f90, 3); or(bl, 0x4);                            /* or bl, 0x4 */
        l_0x1017_2f93:
            ii(0x1017_2f93, 6); mov(memb_a32[ds, 0x101b_e1f2], bl);     /* mov [0x101be1f2], bl */
            ii(0x1017_2f99, 2); jmpd(0x1017_2fce, 0x33); goto l_0x1017_2fce; /* jmp 0x10172fce */
        l_0x1017_2f9b:
            ii(0x1017_2f9b, 4); cmp(ax, 0x2a);                          /* cmp ax, 0x2a */
            ii(0x1017_2f9f, 2); if(jzd(0x1017_2fa7, 0x6)) goto l_0x1017_2fa7; /* jz 0x10172fa7 */
            ii(0x1017_2fa1, 4); cmp(ax, 0x36);                          /* cmp ax, 0x36 */
            ii(0x1017_2fa5, 2); if(jnzd(0x1017_2fd3, 0x2c)) goto l_0x1017_2fd3; /* jnz 0x10172fd3 */
        l_0x1017_2fa7:
            ii(0x1017_2fa7, 6); mov(bl, memb_a32[ds, 0x101b_e1f2]);     /* mov bl, [0x101be1f2] */
            ii(0x1017_2fad, 3); test(bl, 0x2);                          /* test bl, 0x2 */
            ii(0x1017_2fb0, 2); if(jzd(0x1017_2fd3, 0x21)) goto l_0x1017_2fd3; /* jz 0x10172fd3 */
            ii(0x1017_2fb2, 7); cmp(memd_a32[ds, 0x1020_9540], 0);      /* cmp dword [0x10209540], 0x0 */
            ii(0x1017_2fb9, 2); if(jzd(0x1017_2fd3, 0x18)) goto l_0x1017_2fd3; /* jz 0x10172fd3 */
            ii(0x1017_2fbb, 3); test(bl, 0x2);                          /* test bl, 0x2 */
            ii(0x1017_2fbe, 2); if(jzd(0x1017_2fc5, 0x5)) goto l_0x1017_2fc5; /* jz 0x10172fc5 */
            ii(0x1017_2fc0, 3); and(bl, 0xfd);                          /* and bl, 0xfd */
            ii(0x1017_2fc3, 2); jmpd(0x1017_2fc8, 0x3); goto l_0x1017_2fc8; /* jmp 0x10172fc8 */
        l_0x1017_2fc5:
            ii(0x1017_2fc5, 3); or(bl, 0x2);                            /* or bl, 0x2 */
        l_0x1017_2fc8:
            ii(0x1017_2fc8, 6); mov(memb_a32[ds, 0x101b_e1f2], bl);     /* mov [0x101be1f2], bl */
        l_0x1017_2fce:
            ii(0x1017_2fce, 5); calld(/* sys */ 0x1017_8e58, 0x5e85);   /* call 0x10178e58 */
        l_0x1017_2fd3:
            ii(0x1017_2fd3, 6); mov(bl, memb_a32[ds, 0x101b_e1f2]);     /* mov bl, [0x101be1f2] */
            ii(0x1017_2fd9, 2); test(bl, bl);                           /* test bl, bl */
            ii(0x1017_2fdb, 2); if(jzd(0x1017_2ffb, 0x1e)) goto l_0x1017_2ffb; /* jz 0x10172ffb */
            ii(0x1017_2fdd, 3); test(bl, 0x1);                          /* test bl, 0x1 */
            ii(0x1017_2fe0, 2); if(jzd(0x1017_2fe7, 0x5)) goto l_0x1017_2fe7; /* jz 0x10172fe7 */
            ii(0x1017_2fe2, 5); or(memb_a32[ss, esp + 0x2], 0x2);       /* or byte [esp+0x2], 0x2 */
        l_0x1017_2fe7:
            ii(0x1017_2fe7, 3); test(bl, 0x2);                          /* test bl, 0x2 */
            ii(0x1017_2fea, 2); if(jzd(0x1017_2ff1, 0x5)) goto l_0x1017_2ff1; /* jz 0x10172ff1 */
            ii(0x1017_2fec, 5); or(memb_a32[ss, esp + 0x2], 0x1);       /* or byte [esp+0x2], 0x1 */
        l_0x1017_2ff1:
            ii(0x1017_2ff1, 3); test(bl, 0x4);                          /* test bl, 0x4 */
            ii(0x1017_2ff4, 2); if(jzd(0x1017_2ffb, 0x5)) goto l_0x1017_2ffb; /* jz 0x10172ffb */
            ii(0x1017_2ff6, 5); or(memb_a32[ss, esp + 0x2], 0x4);       /* or byte [esp+0x2], 0x4 */
        l_0x1017_2ffb:
            ii(0x1017_2ffb, 7); cmp(memb_a32[ds, 0x1020_946a], 0);      /* cmp byte [0x1020946a], 0x0 */
            ii(0x1017_3002, 2); if(jzd(0x1017_3009, 0x5)) goto l_0x1017_3009; /* jz 0x10173009 */
            ii(0x1017_3004, 5); or(memb_a32[ss, esp + 0x2], 0x8);       /* or byte [esp+0x2], 0x8 */
        l_0x1017_3009:
            ii(0x1017_3009, 7); cmp(memb_a32[ds, 0x1020_9476], 0);      /* cmp byte [0x10209476], 0x0 */
            ii(0x1017_3010, 2); if(jzd(0x1017_3017, 0x5)) goto l_0x1017_3017; /* jz 0x10173017 */
            ii(0x1017_3012, 5); or(memb_a32[ss, esp + 0x2], 0x10);      /* or byte [esp+0x2], 0x10 */
        l_0x1017_3017:
            ii(0x1017_3017, 7); cmp(memb_a32[ds, 0x1020_9478], 0);      /* cmp byte [0x10209478], 0x0 */
            ii(0x1017_301e, 2); if(jzd(0x1017_3025, 0x5)) goto l_0x1017_3025; /* jz 0x10173025 */
            ii(0x1017_3020, 5); or(memb_a32[ss, esp + 0x2], 0x20);      /* or byte [esp+0x2], 0x20 */
        l_0x1017_3025:
            ii(0x1017_3025, 7); cmp(memb_a32[ds, 0x1020_94f8], 0);      /* cmp byte [0x102094f8], 0x0 */
            ii(0x1017_302c, 2); if(jzd(0x1017_3033, 0x5)) goto l_0x1017_3033; /* jz 0x10173033 */
            ii(0x1017_302e, 5); or(memb_a32[ss, esp + 0x2], 0x40);      /* or byte [esp+0x2], 0x40 */
        l_0x1017_3033:
            ii(0x1017_3033, 7); cmp(memb_a32[ds, 0x1020_945d], 0);      /* cmp byte [0x1020945d], 0x0 */
            ii(0x1017_303a, 2); if(jzd(0x1017_3041, 0x5)) goto l_0x1017_3041; /* jz 0x10173041 */
            ii(0x1017_303c, 5); or(memb_a32[ss, esp + 0x2], -0x80 /* 0x80 */); /* or byte [esp+0x2], 0x80 */
        l_0x1017_3041:
            ii(0x1017_3041, 6); mov(memb_a32[ds, 0x101b_e1f2], bl);     /* mov [0x101be1f2], bl */
            ii(0x1017_3047, 7); cmp(memb_a32[ds, 0x1020_94dd], 0);      /* cmp byte [0x102094dd], 0x0 */
            ii(0x1017_304e, 2); if(jzd(0x1017_3055, 0x5)) goto l_0x1017_3055; /* jz 0x10173055 */
            ii(0x1017_3050, 5); or(memb_a32[ss, esp + 0x3], 0x1);       /* or byte [esp+0x3], 0x1 */
        l_0x1017_3055:
            ii(0x1017_3055, 1); cli();                                  /* cli */
            ii(0x1017_3056, 6); mov(edx, memd_a32[ds, 0x101b_e1e8]);    /* mov edx, [0x101be1e8] */
            ii(0x1017_305c, 1); inc(edx);                               /* inc edx */
            ii(0x1017_305d, 6); mov(ecx, memd_a32[ds, 0x101b_e1ec]);    /* mov ecx, [0x101be1ec] */
            ii(0x1017_3063, 3); and(edx, 0x3f);                         /* and edx, 0x3f */
            ii(0x1017_3066, 2); cmp(edx, ecx);                          /* cmp edx, ecx */
            ii(0x1017_3068, 2); if(jzd(0x1017_3080, 0x16)) goto l_0x1017_3080; /* jz 0x10173080 */
            ii(0x1017_306a, 6); mov(ecx, memd_a32[ds, 0x101b_e1e8]);    /* mov ecx, [0x101be1e8] */
            ii(0x1017_3070, 3); mov(esi, memd_a32[ss, esp]);            /* mov esi, [esp] */
            ii(0x1017_3073, 6); mov(memd_a32[ds, 0x101b_e1e8], edx);    /* mov [0x101be1e8], edx */
            ii(0x1017_3079, 7); mov(memd_a32[ds, ecx * 4 + 0x1020_8940], esi); /* mov [ecx*4+0x10208940], esi */
        l_0x1017_3080:
            ii(0x1017_3080, 1); sti();                                  /* sti */
            ii(0x1017_3081, 1); cld();                                  /* cld */
        l_0x1017_3082:
            ii(0x1017_3082, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1017_3084, 6); mov(bl, memb_a32[ds, 0x101b_e1f2]);     /* mov bl, [0x101be1f2] */
            ii(0x1017_308a, 7); mov(memw_a32[ds, 0x101b_e1f0], di);     /* mov [0x101be1f0], di */
        l_0x1017_3091:
            ii(0x1017_3091, 6); mov(memb_a32[ds, 0x101b_e1f2], bl);     /* mov [0x101be1f2], bl */
            ii(0x1017_3097, 7); cmp(memb_a32[ds, 0x1020_9506], 0);      /* cmp byte [0x10209506], 0x0 */
            ii(0x1017_309e, 2); if(jzd(0x1017_30a5, 0x5)) goto l_0x1017_30a5; /* jz 0x101730a5 */
            ii(0x1017_30a0, 5); calld(/* sys */ 0x1017_2bf0, -0x4b5);   /* call 0x10172bf0 */
        l_0x1017_30a5:
            ii(0x1017_30a5, 6); mov(bl, memb_a32[ds, 0x101b_e1f2]);     /* mov bl, [0x101be1f2] */
            ii(0x1017_30ab, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_30ae, 1); popd(edi);                              /* pop edi */
            ii(0x1017_30af, 1); popd(esi);                              /* pop esi */
            ii(0x1017_30b0, 1); popd(edx);                              /* pop edx */
            ii(0x1017_30b1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_30b2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_30b3, 1); retd();                                 /* ret */
        }
    }
}
