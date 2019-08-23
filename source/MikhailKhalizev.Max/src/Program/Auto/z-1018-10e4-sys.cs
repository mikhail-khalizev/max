using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_10e4-b56dd499")]
        public void /* sys */ Method_1018_10e4()
        {
            ii(0x1018_10e4, 1); pushd(esi);                             /* push esi */
            ii(0x1018_10e5, 1); pushd(edi);                             /* push edi */
            ii(0x1018_10e6, 1); pushd(es);                              /* push es */
            ii(0x1018_10e7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_10e8, 6); sub(esp, 0x124);                        /* sub esp, 0x124 */
            ii(0x1018_10ee, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1018_10f0, 7); mov(memd_a32[ss, esp + 0x11c], ecx);    /* mov [esp+0x11c], ecx */
            ii(0x1018_10f7, 2); xor(bl, bl);                            /* xor bl, bl */
            ii(0x1018_10f9, 7); mov(memd_a32[ss, esp + 0x100], eax);    /* mov [esp+0x100], eax */
            ii(0x1018_1100, 7); mov(memb_a32[ss, esp + 0x120], bl);     /* mov [esp+0x120], bl */
            ii(0x1018_1107, 7); mov(memb_a32[ss, esp + 0x114], bl);     /* mov [esp+0x114], bl */
            ii(0x1018_110e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_1110, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1018_1112, 7); mov(memd_a32[ss, esp + 0x110], ebx);    /* mov [esp+0x110], ebx */
            ii(0x1018_1119, 5); mov(ebp, 0x4);                          /* mov ebp, 0x4 */
            ii(0x1018_111e, 5); jmpd(0x1018_11b6, 0x93); goto l_0x1018_11b6; /* jmp 0x101811b6 */
        l_0x1018_1123:
            ii(0x1018_1123, 7); lea(ebx, esp + 0x100);                  /* lea ebx, [esp+0x100] */
            ii(0x1018_112a, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1018_112c, 5); calld(/* sys */ 0x1018_1483, 0x352);    /* call 0x10181483 */
            ii(0x1018_1131, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1018_1133, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1018_1135, 1); inc(edi);                               /* inc edi */
            ii(0x1018_1136, 7); mov(memb_a32[ss, esp + 0x115], al);     /* mov [esp+0x115], al */
            ii(0x1018_113d, 2); test(al, al);                           /* test al, al */
            ii(0x1018_113f, 6); if(jzd(0x1018_1471, 0x32c)) goto l_0x1018_1471; /* jz 0x10181471 */
            ii(0x1018_1145, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_1147, 7); mov(al, memb_a32[ss, esp + 0x115]);     /* mov al, [esp+0x115] */
            ii(0x1018_114e, 3); cmp(eax, 0x6e);                         /* cmp eax, 0x6e */
            ii(0x1018_1151, 6); if(jnzd(0x1018_1280, 0x129)) goto l_0x1018_1280; /* jnz 0x10181280 */
            ii(0x1018_1157, 7); mov(al, memb_a32[ss, esp + 0x114]);     /* mov al, [esp+0x114] */
            ii(0x1018_115e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1160, 2); and(al, 0x20);                          /* and al, 0x20 */
            ii(0x1018_1162, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1018_1164, 7); mov(al, memb_a32[ss, esp + 0x114]);     /* mov al, [esp+0x114] */
            ii(0x1018_116b, 2); and(al, 0x40);                          /* and al, 0x40 */
            ii(0x1018_116d, 7); mov(ah, memb_a32[ss, esp + 0x114]);     /* mov ah, [esp+0x114] */
            ii(0x1018_1174, 3); and(ah, 0x80);                          /* and ah, 0x80 */
            ii(0x1018_1177, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_1179, 6); if(jzd(0x1018_11ed, 0x6e)) goto l_0x1018_11ed; /* jz 0x101811ed */
            ii(0x1018_117f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1181, 2); mov(dl, ah);                            /* mov dl, ah */
            ii(0x1018_1183, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_1185, 2); if(jzd(0x1018_119d, 0x16)) goto l_0x1018_119d; /* jz 0x1018119d */
            ii(0x1018_1187, 2); mov(ecx, memd_a32[ds, esi]);            /* mov ecx, [esi] */
            ii(0x1018_1189, 3); add(ecx, 0x8);                          /* add ecx, 0x8 */
            ii(0x1018_118c, 2); mov(memd_a32[ds, esi], ecx);            /* mov [esi], ecx */
            ii(0x1018_118e, 3); les(edx, ds, ecx - 0x8);                /* les edx, [ecx-0x8] */
        l_0x1018_1191:
            ii(0x1018_1191, 7); mov(eax, memd_a32[ss, esp + 0x110]);    /* mov eax, [esp+0x110] */
            ii(0x1018_1198, 3); mov(memd_a32[es, edx], eax);            /* mov [es:edx], eax */
            ii(0x1018_119b, 2); jmpd(0x1018_11b6, 0x19); goto l_0x1018_11b6; /* jmp 0x101811b6 */
        l_0x1018_119d:
            ii(0x1018_119d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_11a2, 2); if(jzd(0x1018_11e2, 0x3e)) goto l_0x1018_11e2; /* jz 0x101811e2 */
            ii(0x1018_11a4, 2); mov(ebx, memd_a32[ds, esi]);            /* mov ebx, [esi] */
            ii(0x1018_11a6, 2); add(ebx, ebp);                          /* add ebx, ebp */
            ii(0x1018_11a8, 2); mov(memd_a32[ds, esi], ebx);            /* mov [esi], ebx */
            ii(0x1018_11aa, 3); mov(edx, memd_a32[ds, ebx - 0x4]);      /* mov edx, [ebx-0x4] */
        l_0x1018_11ad:
            ii(0x1018_11ad, 7); mov(eax, memd_a32[ss, esp + 0x110]);    /* mov eax, [esp+0x110] */
            ii(0x1018_11b4, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
        l_0x1018_11b6:
            ii(0x1018_11b6, 2); mov(cl, memb_a32[ds, edi]);             /* mov cl, [edi] */
            ii(0x1018_11b8, 2); test(cl, cl);                           /* test cl, cl */
            ii(0x1018_11ba, 6); if(jzd(0x1018_1471, 0x2b1)) goto l_0x1018_1471; /* jz 0x10181471 */
            ii(0x1018_11c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_11c2, 2); mov(dl, cl);                            /* mov dl, cl */
            ii(0x1018_11c4, 3); lea(eax, edi + 0x1);                    /* lea eax, [edi+0x1] */
            ii(0x1018_11c7, 3); cmp(edx, 0x25);                         /* cmp edx, 0x25 */
            ii(0x1018_11ca, 6); if(jzd(0x1018_1123, -0xad)) goto l_0x1018_1123; /* jz 0x10181123 */
            ii(0x1018_11d0, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1018_11d2, 7); lea(eax, esp + 0x100);                  /* lea eax, [esp+0x100] */
            ii(0x1018_11d9, 7); calld_abs(memd_a32[ss, esp + 0x11c]);   /* call dword [esp+0x11c] */
            ii(0x1018_11e0, 2); jmpd(0x1018_11b6, -0x2c); goto l_0x1018_11b6; /* jmp 0x101811b6 */
        l_0x1018_11e2:
            ii(0x1018_11e2, 2); mov(edx, memd_a32[ds, esi]);            /* mov edx, [esi] */
            ii(0x1018_11e4, 2); add(edx, ebp);                          /* add edx, ebp */
            ii(0x1018_11e6, 2); mov(memd_a32[ds, esi], edx);            /* mov [esi], edx */
            ii(0x1018_11e8, 3); mov(edx, memd_a32[ds, edx - 0x4]);      /* mov edx, [edx-0x4] */
            ii(0x1018_11eb, 2); jmpd(0x1018_11ad, -0x40); goto l_0x1018_11ad; /* jmp 0x101811ad */
        l_0x1018_11ed:
            ii(0x1018_11ed, 7); mov(dl, memb_a32[ss, esp + 0x114]);     /* mov dl, [esp+0x114] */
            ii(0x1018_11f4, 3); and(dl, 0x10);                          /* and dl, 0x10 */
            ii(0x1018_11f7, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_11fd, 2); if(jzd(0x1018_1248, 0x49)) goto l_0x1018_1248; /* jz 0x10181248 */
            ii(0x1018_11ff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1201, 2); mov(dl, ah);                            /* mov dl, ah */
            ii(0x1018_1203, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_1205, 2); if(jzd(0x1018_121e, 0x17)) goto l_0x1018_121e; /* jz 0x1018121e */
            ii(0x1018_1207, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1018_1209, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1018_120c, 2); mov(memd_a32[ds, esi], eax);            /* mov [esi], eax */
            ii(0x1018_120e, 3); les(edx, ds, eax - 0x8);                /* les edx, [eax-0x8] */
            ii(0x1018_1211, 7); mov(eax, memd_a32[ss, esp + 0x110]);    /* mov eax, [esp+0x110] */
            ii(0x1018_1218, 4); mov(memw_a32[es, edx], ax);             /* mov [es:edx], ax */
            ii(0x1018_121c, 2); jmpd(0x1018_11b6, -0x68); goto l_0x1018_11b6; /* jmp 0x101811b6 */
        l_0x1018_121e:
            ii(0x1018_121e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_1223, 2); if(jzd(0x1018_123d, 0x18)) goto l_0x1018_123d; /* jz 0x1018123d */
            ii(0x1018_1225, 2); mov(ecx, memd_a32[ds, esi]);            /* mov ecx, [esi] */
            ii(0x1018_1227, 2); add(ecx, ebp);                          /* add ecx, ebp */
            ii(0x1018_1229, 2); mov(memd_a32[ds, esi], ecx);            /* mov [esi], ecx */
            ii(0x1018_122b, 3); mov(edx, memd_a32[ds, ecx - 0x4]);      /* mov edx, [ecx-0x4] */
        l_0x1018_122e:
            ii(0x1018_122e, 7); mov(eax, memd_a32[ss, esp + 0x110]);    /* mov eax, [esp+0x110] */
            ii(0x1018_1235, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1018_1238, 5); jmpd(0x1018_11b6, -0x87); goto l_0x1018_11b6; /* jmp 0x101811b6 */
        l_0x1018_123d:
            ii(0x1018_123d, 2); mov(ebx, memd_a32[ds, esi]);            /* mov ebx, [esi] */
            ii(0x1018_123f, 2); add(ebx, ebp);                          /* add ebx, ebp */
            ii(0x1018_1241, 2); mov(memd_a32[ds, esi], ebx);            /* mov [esi], ebx */
            ii(0x1018_1243, 3); mov(edx, memd_a32[ds, ebx - 0x4]);      /* mov edx, [ebx-0x4] */
            ii(0x1018_1246, 2); jmpd(0x1018_122e, -0x1a); goto l_0x1018_122e; /* jmp 0x1018122e */
        l_0x1018_1248:
            ii(0x1018_1248, 2); mov(dl, ah);                            /* mov dl, ah */
            ii(0x1018_124a, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_124c, 2); if(jzd(0x1018_125d, 0xf)) goto l_0x1018_125d; /* jz 0x1018125d */
            ii(0x1018_124e, 2); mov(edx, memd_a32[ds, esi]);            /* mov edx, [esi] */
            ii(0x1018_1250, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1018_1253, 2); mov(memd_a32[ds, esi], edx);            /* mov [esi], edx */
            ii(0x1018_1255, 3); les(edx, ds, edx - 0x8);                /* les edx, [edx-0x8] */
            ii(0x1018_1258, 5); jmpd(0x1018_1191, -0xcc); goto l_0x1018_1191; /* jmp 0x10181191 */
        l_0x1018_125d:
            ii(0x1018_125d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_1262, 2); if(jzd(0x1018_1272, 0xe)) goto l_0x1018_1272; /* jz 0x10181272 */
            ii(0x1018_1264, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1018_1266, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1018_1268, 2); mov(memd_a32[ds, esi], eax);            /* mov [esi], eax */
            ii(0x1018_126a, 3); mov(edx, memd_a32[ds, eax - 0x4]);      /* mov edx, [eax-0x4] */
            ii(0x1018_126d, 5); jmpd(0x1018_11ad, -0xc5); goto l_0x1018_11ad; /* jmp 0x101811ad */
        l_0x1018_1272:
            ii(0x1018_1272, 2); mov(ecx, memd_a32[ds, esi]);            /* mov ecx, [esi] */
            ii(0x1018_1274, 2); add(ecx, ebp);                          /* add ecx, ebp */
            ii(0x1018_1276, 2); mov(memd_a32[ds, esi], ecx);            /* mov [esi], ecx */
            ii(0x1018_1278, 3); mov(edx, memd_a32[ds, ecx - 0x4]);      /* mov edx, [ecx-0x4] */
            ii(0x1018_127b, 5); jmpd(0x1018_11ad, -0xd3); goto l_0x1018_11ad; /* jmp 0x101811ad */
        l_0x1018_1280:
            ii(0x1018_1280, 7); lea(ecx, esp + 0x120);                  /* lea ecx, [esp+0x120] */
            ii(0x1018_1287, 7); lea(ebx, esp + 0x100);                  /* lea ebx, [esp+0x100] */
            ii(0x1018_128e, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1018_1290, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1018_1292, 5); calld(/* sys */ 0x1018_17c1, 0x52a);    /* call 0x101817c1 */
            ii(0x1018_1297, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_1299, 7); mov(al, memb_a32[ss, esp + 0x114]);     /* mov al, [esp+0x114] */
            ii(0x1018_12a0, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1018_12a2, 2); and(al, 0x8);                           /* and al, 0x8 */
            ii(0x1018_12a4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_12a9, 2); if(jnzd(0x1018_12e3, 0x38)) goto l_0x1018_12e3; /* jnz 0x101812e3 */
            ii(0x1018_12ab, 7); mov(al, memb_a32[ss, esp + 0x116]);     /* mov al, [esp+0x116] */
            ii(0x1018_12b2, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1018_12b5, 2); if(jnzd(0x1018_12e3, 0x2c)) goto l_0x1018_12e3; /* jnz 0x101812e3 */
        l_0x1018_12b7:
            ii(0x1018_12b7, 7); mov(eax, memd_a32[ss, esp + 0x104]);    /* mov eax, [esp+0x104] */
            ii(0x1018_12be, 1); dec(eax);                               /* dec eax */
            ii(0x1018_12bf, 7); mov(memd_a32[ss, esp + 0x104], eax);    /* mov [esp+0x104], eax */
            ii(0x1018_12c6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_12c8, 2); if(jld(0x1018_12e3, 0x19)) goto l_0x1018_12e3; /* jl 0x101812e3 */
            ii(0x1018_12ca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_12cc, 7); lea(eax, esp + 0x100);                  /* lea eax, [esp+0x100] */
            ii(0x1018_12d3, 7); mov(dl, memb_a32[ss, esp + 0x116]);     /* mov dl, [esp+0x116] */
            ii(0x1018_12da, 7); calld_abs(memd_a32[ss, esp + 0x11c]);   /* call dword [esp+0x11c] */
            ii(0x1018_12e1, 2); jmpd(0x1018_12b7, -0x2c); goto l_0x1018_12b7; /* jmp 0x101812b7 */
        l_0x1018_12e3:
            ii(0x1018_12e3, 7); lea(ecx, esp + 0x117);                  /* lea ecx, [esp+0x117] */
        l_0x1018_12ea:
            ii(0x1018_12ea, 2); mov(al, memb_a32[ds, ecx]);             /* mov al, [ecx] */
            ii(0x1018_12ec, 2); test(al, al);                           /* test al, al */
            ii(0x1018_12ee, 2); if(jzd(0x1018_1305, 0x15)) goto l_0x1018_1305; /* jz 0x10181305 */
            ii(0x1018_12f0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_12f2, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1018_12f4, 7); lea(eax, esp + 0x100);                  /* lea eax, [esp+0x100] */
            ii(0x1018_12fb, 1); inc(ecx);                               /* inc ecx */
            ii(0x1018_12fc, 7); calld_abs(memd_a32[ss, esp + 0x11c]);   /* call dword [esp+0x11c] */
            ii(0x1018_1303, 2); jmpd(0x1018_12ea, -0x1b); goto l_0x1018_12ea; /* jmp 0x101812ea */
        l_0x1018_1305:
            ii(0x1018_1305, 7); mov(eax, memd_a32[ss, esp + 0x10c]);    /* mov eax, [esp+0x10c] */
            ii(0x1018_130c, 3); lea(ecx, eax - 0x1);                    /* lea ecx, [eax-0x1] */
            ii(0x1018_130f, 7); mov(memd_a32[ss, esp + 0x10c], ecx);    /* mov [esp+0x10c], ecx */
            ii(0x1018_1316, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_1318, 2); if(jzd(0x1018_132f, 0x15)) goto l_0x1018_132f; /* jz 0x1018132f */
            ii(0x1018_131a, 5); mov(edx, 0x30);                         /* mov edx, 0x30 */
            ii(0x1018_131f, 7); lea(eax, esp + 0x100);                  /* lea eax, [esp+0x100] */
            ii(0x1018_1326, 7); calld_abs(memd_a32[ss, esp + 0x11c]);   /* call dword [esp+0x11c] */
            ii(0x1018_132d, 2); jmpd(0x1018_1305, -0x2a); goto l_0x1018_1305; /* jmp 0x10181305 */
        l_0x1018_132f:
            ii(0x1018_132f, 7); mov(al, memb_a32[ss, esp + 0x114]);     /* mov al, [esp+0x114] */
            ii(0x1018_1336, 2); and(al, 0x8);                           /* and al, 0x8 */
            ii(0x1018_1338, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_133d, 2); if(jnzd(0x1018_1377, 0x38)) goto l_0x1018_1377; /* jnz 0x10181377 */
            ii(0x1018_133f, 7); mov(al, memb_a32[ss, esp + 0x116]);     /* mov al, [esp+0x116] */
            ii(0x1018_1346, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1018_1349, 2); if(jzd(0x1018_1377, 0x2c)) goto l_0x1018_1377; /* jz 0x10181377 */
        l_0x1018_134b:
            ii(0x1018_134b, 7); mov(eax, memd_a32[ss, esp + 0x104]);    /* mov eax, [esp+0x104] */
            ii(0x1018_1352, 1); dec(eax);                               /* dec eax */
            ii(0x1018_1353, 7); mov(memd_a32[ss, esp + 0x104], eax);    /* mov [esp+0x104], eax */
            ii(0x1018_135a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_135c, 2); if(jld(0x1018_1377, 0x19)) goto l_0x1018_1377; /* jl 0x10181377 */
            ii(0x1018_135e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1360, 7); lea(eax, esp + 0x100);                  /* lea eax, [esp+0x100] */
            ii(0x1018_1367, 7); mov(dl, memb_a32[ss, esp + 0x116]);     /* mov dl, [esp+0x116] */
            ii(0x1018_136e, 7); calld_abs(memd_a32[ss, esp + 0x11c]);   /* call dword [esp+0x11c] */
            ii(0x1018_1375, 2); jmpd(0x1018_134b, -0x2c); goto l_0x1018_134b; /* jmp 0x1018134b */
        l_0x1018_1377:
            ii(0x1018_1377, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_1379, 7); mov(al, memb_a32[ss, esp + 0x115]);     /* mov al, [esp+0x115] */
            ii(0x1018_1380, 3); cmp(eax, 0x73);                         /* cmp eax, 0x73 */
            ii(0x1018_1383, 2); if(jzd(0x1018_138a, 0x5)) goto l_0x1018_138a; /* jz 0x1018138a */
            ii(0x1018_1385, 3); cmp(eax, 0x53);                         /* cmp eax, 0x53 */
            ii(0x1018_1388, 2); if(jnzd(0x1018_13f6, 0x6c)) goto l_0x1018_13f6; /* jnz 0x101813f6 */
        l_0x1018_138a:
            ii(0x1018_138a, 7); mov(al, memb_a32[ss, esp + 0x114]);     /* mov al, [esp+0x114] */
            ii(0x1018_1391, 2); and(al, 0x20);                          /* and al, 0x20 */
            ii(0x1018_1393, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_1398, 2); if(jzd(0x1018_13cb, 0x31)) goto l_0x1018_13cb; /* jz 0x101813cb */
        l_0x1018_139a:
            ii(0x1018_139a, 7); mov(eax, memd_a32[ss, esp + 0x108]);    /* mov eax, [esp+0x108] */
            ii(0x1018_13a1, 3); lea(ecx, eax - 0x1);                    /* lea ecx, [eax-0x1] */
            ii(0x1018_13a4, 7); mov(memd_a32[ss, esp + 0x108], ecx);    /* mov [esp+0x108], ecx */
            ii(0x1018_13ab, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_13ad, 6); if(jzd(0x1018_1421, 0x6e)) goto l_0x1018_1421; /* jz 0x10181421 */
            ii(0x1018_13b3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_13b5, 7); lea(eax, esp + 0x100);                  /* lea eax, [esp+0x100] */
            ii(0x1018_13bc, 3); mov(dl, memb_a32[es, ebx]);             /* mov dl, [es:ebx] */
            ii(0x1018_13bf, 7); calld_abs(memd_a32[ss, esp + 0x11c]);   /* call dword [esp+0x11c] */
            ii(0x1018_13c6, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x1018_13c9, 2); jmpd(0x1018_139a, -0x31); goto l_0x1018_139a; /* jmp 0x1018139a */
        l_0x1018_13cb:
            ii(0x1018_13cb, 7); mov(eax, memd_a32[ss, esp + 0x108]);    /* mov eax, [esp+0x108] */
            ii(0x1018_13d2, 3); lea(edx, eax - 0x1);                    /* lea edx, [eax-0x1] */
            ii(0x1018_13d5, 7); mov(memd_a32[ss, esp + 0x108], edx);    /* mov [esp+0x108], edx */
            ii(0x1018_13dc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_13de, 2); if(jzd(0x1018_1421, 0x41)) goto l_0x1018_1421; /* jz 0x10181421 */
            ii(0x1018_13e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_13e2, 7); lea(eax, esp + 0x100);                  /* lea eax, [esp+0x100] */
            ii(0x1018_13e9, 3); mov(dl, memb_a32[es, ebx]);             /* mov dl, [es:ebx] */
            ii(0x1018_13ec, 7); calld_abs(memd_a32[ss, esp + 0x11c]);   /* call dword [esp+0x11c] */
            ii(0x1018_13f3, 1); inc(ebx);                               /* inc ebx */
            ii(0x1018_13f4, 2); jmpd(0x1018_13cb, -0x2b); goto l_0x1018_13cb; /* jmp 0x101813cb */
        l_0x1018_13f6:
            ii(0x1018_13f6, 7); mov(eax, memd_a32[ss, esp + 0x108]);    /* mov eax, [esp+0x108] */
            ii(0x1018_13fd, 3); lea(ecx, eax - 0x1);                    /* lea ecx, [eax-0x1] */
            ii(0x1018_1400, 7); mov(memd_a32[ss, esp + 0x108], ecx);    /* mov [esp+0x108], ecx */
            ii(0x1018_1407, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_1409, 2); if(jzd(0x1018_1421, 0x16)) goto l_0x1018_1421; /* jz 0x10181421 */
            ii(0x1018_140b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_140d, 7); lea(eax, esp + 0x100);                  /* lea eax, [esp+0x100] */
            ii(0x1018_1414, 3); mov(dl, memb_a32[es, ebx]);             /* mov dl, [es:ebx] */
            ii(0x1018_1417, 7); calld_abs(memd_a32[ss, esp + 0x11c]);   /* call dword [esp+0x11c] */
            ii(0x1018_141e, 1); inc(ebx);                               /* inc ebx */
            ii(0x1018_141f, 2); jmpd(0x1018_13f6, -0x2b); goto l_0x1018_13f6; /* jmp 0x101813f6 */
        l_0x1018_1421:
            ii(0x1018_1421, 7); mov(al, memb_a32[ss, esp + 0x114]);     /* mov al, [esp+0x114] */
            ii(0x1018_1428, 2); and(al, 0x8);                           /* and al, 0x8 */
            ii(0x1018_142a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_142f, 6); if(jzd(0x1018_11b6, -0x27f)) goto l_0x1018_11b6; /* jz 0x101811b6 */
            ii(0x1018_1435, 8); cmp(memd_a32[ss, esp + 0x104], 0);      /* cmp dword [esp+0x104], 0x0 */
            ii(0x1018_143d, 6); if(jled(0x1018_11b6, -0x28d)) goto l_0x1018_11b6; /* jle 0x101811b6 */
        l_0x1018_1443:
            ii(0x1018_1443, 7); mov(eax, memd_a32[ss, esp + 0x104]);    /* mov eax, [esp+0x104] */
            ii(0x1018_144a, 3); lea(edx, eax - 0x1);                    /* lea edx, [eax-0x1] */
            ii(0x1018_144d, 7); mov(memd_a32[ss, esp + 0x104], edx);    /* mov [esp+0x104], edx */
            ii(0x1018_1454, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_1456, 6); if(jzd(0x1018_11b6, -0x2a6)) goto l_0x1018_11b6; /* jz 0x101811b6 */
            ii(0x1018_145c, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1018_1461, 7); lea(eax, esp + 0x100);                  /* lea eax, [esp+0x100] */
            ii(0x1018_1468, 7); calld_abs(memd_a32[ss, esp + 0x11c]);   /* call dword [esp+0x11c] */
            ii(0x1018_146f, 2); jmpd(0x1018_1443, -0x2e); goto l_0x1018_1443; /* jmp 0x10181443 */
        l_0x1018_1471:
            ii(0x1018_1471, 7); mov(eax, memd_a32[ss, esp + 0x110]);    /* mov eax, [esp+0x110] */
            ii(0x1018_1478, 6); add(esp, 0x124);                        /* add esp, 0x124 */
            ii(0x1018_147e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_147f, 1); popd(es);                               /* pop es */
            ii(0x1018_1480, 1); popd(edi);                              /* pop edi */
            ii(0x1018_1481, 1); popd(esi);                              /* pop esi */
            ii(0x1018_1482, 1); retd();                                 /* ret */
        }
    }
}
