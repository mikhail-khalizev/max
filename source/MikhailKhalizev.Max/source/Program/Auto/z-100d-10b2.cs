using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_10b2-6b8fa8a3")]
        public void Method_100d_10b2()
        {
            ii(0x100d_10b2, 5);  push(0xb8);                           /* push 0xb8 */
            ii(0x100d_10b7, 5);  call(Definitions.sys_check_available_stack_size, 0x9_4c96);/* call 0x10165d52 */
            ii(0x100d_10bc, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_10bd, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_10be, 1);  push(esi);                            /* push esi */
            ii(0x100d_10bf, 1);  push(edi);                            /* push edi */
            ii(0x100d_10c0, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_10c1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_10c3, 6);  sub(esp, 0xa0);                       /* sub esp, 0xa0 */
            ii(0x100d_10c9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_10cc, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_10cf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_10d2, 7);  mov(memd[ds, eax + 19], 0x101b_5c88); /* mov dword [eax+0x13], 0x101b5c88 */
            ii(0x100d_10d9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_10dc, 3);  mov(eax, memd[ds, eax + 62]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_10df, 3);  mov(memd[ss, ebp - 116], eax);        /* mov [ebp-0x74], eax */
            ii(0x100d_10e2, 4);  cmp(memd[ss, ebp - 116], 0);          /* cmp dword [ebp-0x74], 0x0 */
            ii(0x100d_10e6, 2);  if(jz(0x100d_1103, 0x1b)) goto l_0x100d_1103;/* jz 0x100d1103 */
            ii(0x100d_10e8, 3);  mov(eax, memd[ss, ebp - 116]);        /* mov eax, [ebp-0x74] */
            ii(0x100d_10eb, 3);  mov(memd[ss, ebp - 120], eax);        /* mov [ebp-0x78], eax */
            ii(0x100d_10ee, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x100d_10f1, 3);  mov(ebx, memd[ds, eax + 64]);         /* mov ebx, [eax+0x40] */
            ii(0x100d_10f4, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x100d_10f9, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x100d_10fc, 2);  call_abs(memd[ds, ebx]);              /* call dword [ebx] */
            ii(0x100d_10fe, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_1101, 2);  jmp(0x100d_110a, 7); goto l_0x100d_110a;/* jmp 0x100d110a */
        l_0x100d_1103:
            ii(0x100d_1103, 7);  mov(memd[ss, ebp - 48], 0);           /* mov dword [ebp-0x30], 0x0 */
        l_0x100d_110a:
            ii(0x100d_110a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_110d, 3);  mov(eax, memd[ds, eax + 66]);         /* mov eax, [eax+0x42] */
            ii(0x100d_1110, 3);  mov(memd[ss, ebp - 112], eax);        /* mov [ebp-0x70], eax */
            ii(0x100d_1113, 4);  cmp(memd[ss, ebp - 112], 0);          /* cmp dword [ebp-0x70], 0x0 */
            ii(0x100d_1117, 2);  if(jz(0x100d_112d, 0x14)) goto l_0x100d_112d;/* jz 0x100d112d */
            ii(0x100d_1119, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_111b, 3);  mov(eax, memd[ss, ebp - 112]);        /* mov eax, [ebp-0x70] */
            ii(0x100d_111e, 5);  call(Definitions.my_dtor_d2, -0x2beb);/* call 0x100ce538 */
            ii(0x100d_1123, 5);  call(Definitions.sys_delete, 0x9_4e3c);/* call 0x10165f64 */
            ii(0x100d_1128, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100d_112b, 2);  jmp(0x100d_1134, 7); goto l_0x100d_1134;/* jmp 0x100d1134 */
        l_0x100d_112d:
            ii(0x100d_112d, 7);  mov(memd[ss, ebp - 44], 0);           /* mov dword [ebp-0x2c], 0x0 */
        l_0x100d_1134:
            ii(0x100d_1134, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1137, 3);  mov(eax, memd[ds, eax + 70]);         /* mov eax, [eax+0x46] */
            ii(0x100d_113a, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
            ii(0x100d_113d, 4);  cmp(memd[ss, ebp - 108], 0);          /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x100d_1141, 2);  if(jz(0x100d_1157, 0x14)) goto l_0x100d_1157;/* jz 0x100d1157 */
            ii(0x100d_1143, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_1145, 3);  mov(eax, memd[ss, ebp - 108]);        /* mov eax, [ebp-0x6c] */
            ii(0x100d_1148, 5);  call(Definitions.my_dtor_d2, -0x2c15);/* call 0x100ce538 */
            ii(0x100d_114d, 5);  call(Definitions.sys_delete, 0x9_4e12);/* call 0x10165f64 */
            ii(0x100d_1152, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_1155, 2);  jmp(0x100d_115e, 7); goto l_0x100d_115e;/* jmp 0x100d115e */
        l_0x100d_1157:
            ii(0x100d_1157, 7);  mov(memd[ss, ebp - 40], 0);           /* mov dword [ebp-0x28], 0x0 */
        l_0x100d_115e:
            ii(0x100d_115e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1161, 3);  mov(eax, memd[ds, eax + 74]);         /* mov eax, [eax+0x4a] */
            ii(0x100d_1164, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
            ii(0x100d_1167, 4);  cmp(memd[ss, ebp - 104], 0);          /* cmp dword [ebp-0x68], 0x0 */
            ii(0x100d_116b, 2);  if(jz(0x100d_1181, 0x14)) goto l_0x100d_1181;/* jz 0x100d1181 */
            ii(0x100d_116d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_116f, 3);  mov(eax, memd[ss, ebp - 104]);        /* mov eax, [ebp-0x68] */
            ii(0x100d_1172, 5);  call(Definitions.my_dtor_d2, -0x2c3f);/* call 0x100ce538 */
            ii(0x100d_1177, 5);  call(Definitions.sys_delete, 0x9_4de8);/* call 0x10165f64 */
            ii(0x100d_117c, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_117f, 2);  jmp(0x100d_1188, 7); goto l_0x100d_1188;/* jmp 0x100d1188 */
        l_0x100d_1181:
            ii(0x100d_1181, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
        l_0x100d_1188:
            ii(0x100d_1188, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_118b, 3);  mov(eax, memd[ds, eax + 78]);         /* mov eax, [eax+0x4e] */
            ii(0x100d_118e, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x100d_1191, 4);  cmp(memd[ss, ebp - 100], 0);          /* cmp dword [ebp-0x64], 0x0 */
            ii(0x100d_1195, 2);  if(jz(0x100d_11ab, 0x14)) goto l_0x100d_11ab;/* jz 0x100d11ab */
            ii(0x100d_1197, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_1199, 3);  mov(eax, memd[ss, ebp - 100]);        /* mov eax, [ebp-0x64] */
            ii(0x100d_119c, 5);  call(Definitions.my_dtor_d2, -0x2c69);/* call 0x100ce538 */
            ii(0x100d_11a1, 5);  call(Definitions.sys_delete, 0x9_4dbe);/* call 0x10165f64 */
            ii(0x100d_11a6, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_11a9, 2);  jmp(0x100d_11b2, 7); goto l_0x100d_11b2;/* jmp 0x100d11b2 */
        l_0x100d_11ab:
            ii(0x100d_11ab, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x100d_11b2:
            ii(0x100d_11b2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_11b5, 3);  mov(eax, memd[ds, eax + 82]);         /* mov eax, [eax+0x52] */
            ii(0x100d_11b8, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_11bb, 4);  cmp(memd[ss, ebp - 96], 0);           /* cmp dword [ebp-0x60], 0x0 */
            ii(0x100d_11bf, 2);  if(jz(0x100d_11d5, 0x14)) goto l_0x100d_11d5;/* jz 0x100d11d5 */
            ii(0x100d_11c1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_11c3, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x100d_11c6, 5);  call(Definitions.my_dtor_d2, -0x2c93);/* call 0x100ce538 */
            ii(0x100d_11cb, 5);  call(Definitions.sys_delete, 0x9_4d94);/* call 0x10165f64 */
            ii(0x100d_11d0, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_11d3, 2);  jmp(0x100d_11dc, 7); goto l_0x100d_11dc;/* jmp 0x100d11dc */
        l_0x100d_11d5:
            ii(0x100d_11d5, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x100d_11dc:
            ii(0x100d_11dc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_11df, 3);  mov(eax, memd[ds, eax + 86]);         /* mov eax, [eax+0x56] */
            ii(0x100d_11e2, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_11e5, 4);  cmp(memd[ss, ebp - 92], 0);           /* cmp dword [ebp-0x5c], 0x0 */
            ii(0x100d_11e9, 2);  if(jz(0x100d_11ff, 0x14)) goto l_0x100d_11ff;/* jz 0x100d11ff */
            ii(0x100d_11eb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_11ed, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x100d_11f0, 5);  call(Definitions.my_dtor_d2, -0x2cbd);/* call 0x100ce538 */
            ii(0x100d_11f5, 5);  call(Definitions.sys_delete, 0x9_4d6a);/* call 0x10165f64 */
            ii(0x100d_11fa, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_11fd, 2);  jmp(0x100d_1206, 7); goto l_0x100d_1206;/* jmp 0x100d1206 */
        l_0x100d_11ff:
            ii(0x100d_11ff, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x100d_1206:
            ii(0x100d_1206, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1209, 3);  mov(eax, memd[ds, eax + 94]);         /* mov eax, [eax+0x5e] */
            ii(0x100d_120c, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_120f, 4);  cmp(memd[ss, ebp - 88], 0);           /* cmp dword [ebp-0x58], 0x0 */
            ii(0x100d_1213, 2);  if(jz(0x100d_1229, 0x14)) goto l_0x100d_1229;/* jz 0x100d1229 */
            ii(0x100d_1215, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_1217, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x100d_121a, 5);  call(Definitions.my_dtor_d2, -0x2ce7);/* call 0x100ce538 */
            ii(0x100d_121f, 5);  call(Definitions.sys_delete, 0x9_4d40);/* call 0x10165f64 */
            ii(0x100d_1224, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_1227, 2);  jmp(0x100d_1230, 7); goto l_0x100d_1230;/* jmp 0x100d1230 */
        l_0x100d_1229:
            ii(0x100d_1229, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
        l_0x100d_1230:
            ii(0x100d_1230, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1233, 3);  mov(eax, memd[ds, eax + 98]);         /* mov eax, [eax+0x62] */
            ii(0x100d_1236, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_1239, 4);  cmp(memd[ss, ebp - 84], 0);           /* cmp dword [ebp-0x54], 0x0 */
            ii(0x100d_123d, 2);  if(jz(0x100d_1253, 0x14)) goto l_0x100d_1253;/* jz 0x100d1253 */
            ii(0x100d_123f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_1241, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x100d_1244, 5);  call(Definitions.my_dtor_d2, -0x2d11);/* call 0x100ce538 */
            ii(0x100d_1249, 5);  call(Definitions.sys_delete, 0x9_4d16);/* call 0x10165f64 */
            ii(0x100d_124e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_1251, 2);  jmp(0x100d_125a, 7); goto l_0x100d_125a;/* jmp 0x100d125a */
        l_0x100d_1253:
            ii(0x100d_1253, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x100d_125a:
            ii(0x100d_125a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_125d, 3);  mov(eax, memd[ds, eax + 102]);        /* mov eax, [eax+0x66] */
            ii(0x100d_1260, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_1263, 4);  cmp(memd[ss, ebp - 80], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x100d_1267, 2);  if(jz(0x100d_127d, 0x14)) goto l_0x100d_127d;/* jz 0x100d127d */
            ii(0x100d_1269, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_126b, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_126e, 5);  call(Definitions.my_dtor_d2, -0x2d3b);/* call 0x100ce538 */
            ii(0x100d_1273, 5);  call(Definitions.sys_delete, 0x9_4cec);/* call 0x10165f64 */
            ii(0x100d_1278, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_127b, 2);  jmp(0x100d_1284, 7); goto l_0x100d_1284;/* jmp 0x100d1284 */
        l_0x100d_127d:
            ii(0x100d_127d, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
        l_0x100d_1284:
            ii(0x100d_1284, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1287, 4);  cmp(memd[ds, eax + 90], 0);           /* cmp dword [eax+0x5a], 0x0 */
            ii(0x100d_128b, 2);  if(jz(0x100d_12c0, 0x33)) goto l_0x100d_12c0;/* jz 0x100d12c0 */
            ii(0x100d_128d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1290, 3);  mov(eax, memd[ds, eax + 90]);         /* mov eax, [eax+0x5a] */
            ii(0x100d_1293, 6);  mov(memd[ss, ebp - 132], eax);        /* mov [ebp-0x84], eax */
            ii(0x100d_1299, 7);  cmp(memd[ss, ebp - 132], 0);          /* cmp dword [ebp-0x84], 0x0 */
            ii(0x100d_12a0, 2);  if(jz(0x100d_12b9, 0x17)) goto l_0x100d_12b9;/* jz 0x100d12b9 */
            ii(0x100d_12a2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_12a4, 6);  mov(eax, memd[ss, ebp - 132]);        /* mov eax, [ebp-0x84] */
            ii(0x100d_12aa, 5);  call(Definitions.my_dtor_d2, -0x2d77);/* call 0x100ce538 */
            ii(0x100d_12af, 5);  call(Definitions.sys_delete, 0x9_4cb0);/* call 0x10165f64 */
            ii(0x100d_12b4, 3);  mov(memd[ss, ebp - 128], eax);        /* mov [ebp-0x80], eax */
            ii(0x100d_12b7, 2);  jmp(0x100d_12c0, 7); goto l_0x100d_12c0;/* jmp 0x100d12c0 */
        l_0x100d_12b9:
            ii(0x100d_12b9, 7);  mov(memd[ss, ebp - 128], 0);          /* mov dword [ebp-0x80], 0x0 */
        l_0x100d_12c0:
            ii(0x100d_12c0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_12c3, 3);  mov(eax, memd[ds, eax + 106]);        /* mov eax, [eax+0x6a] */
            ii(0x100d_12c6, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_12c9, 4);  cmp(memd[ss, ebp - 76], 0);           /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x100d_12cd, 2);  if(jz(0x100d_12e6, 0x17)) goto l_0x100d_12e6;/* jz 0x100d12e6 */
            ii(0x100d_12cf, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_12d1, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_12d4, 5);  call(Definitions.my_dtor_d3, 0x6a5a); /* call 0x100d7d33 */
            ii(0x100d_12d9, 5);  call(Definitions.sys_delete, 0x9_4c86);/* call 0x10165f64 */
            ii(0x100d_12de, 6);  mov(memd[ss, ebp - 160], eax);        /* mov [ebp-0xa0], eax */
            ii(0x100d_12e4, 2);  jmp(0x100d_12f0, 0xa); goto l_0x100d_12f0;/* jmp 0x100d12f0 */
        l_0x100d_12e6:
            ii(0x100d_12e6, 10);  mov(memd[ss, ebp - 160], 0);         /* mov dword [ebp-0xa0], 0x0 */
        l_0x100d_12f0:
            ii(0x100d_12f0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_12f3, 3);  mov(eax, memd[ds, eax + 110]);        /* mov eax, [eax+0x6e] */
            ii(0x100d_12f6, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x100d_12f9, 4);  cmp(memd[ss, ebp - 72], 0);           /* cmp dword [ebp-0x48], 0x0 */
            ii(0x100d_12fd, 2);  if(jz(0x100d_1316, 0x17)) goto l_0x100d_1316;/* jz 0x100d1316 */
            ii(0x100d_12ff, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_1301, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x100d_1304, 5);  call(Definitions.my_dtor_d3, 0x6a2a); /* call 0x100d7d33 */
            ii(0x100d_1309, 5);  call(Definitions.sys_delete, 0x9_4c56);/* call 0x10165f64 */
            ii(0x100d_130e, 6);  mov(memd[ss, ebp - 156], eax);        /* mov [ebp-0x9c], eax */
            ii(0x100d_1314, 2);  jmp(0x100d_1320, 0xa); goto l_0x100d_1320;/* jmp 0x100d1320 */
        l_0x100d_1316:
            ii(0x100d_1316, 10);  mov(memd[ss, ebp - 156], 0);         /* mov dword [ebp-0x9c], 0x0 */
        l_0x100d_1320:
            ii(0x100d_1320, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1323, 3);  mov(eax, memd[ds, eax + 114]);        /* mov eax, [eax+0x72] */
            ii(0x100d_1326, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x100d_1329, 4);  cmp(memd[ss, ebp - 68], 0);           /* cmp dword [ebp-0x44], 0x0 */
            ii(0x100d_132d, 2);  if(jz(0x100d_1346, 0x17)) goto l_0x100d_1346;/* jz 0x100d1346 */
            ii(0x100d_132f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_1331, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x100d_1334, 5);  call(Definitions.my_dtor_d3, 0x69fa); /* call 0x100d7d33 */
            ii(0x100d_1339, 5);  call(Definitions.sys_delete, 0x9_4c26);/* call 0x10165f64 */
            ii(0x100d_133e, 6);  mov(memd[ss, ebp - 152], eax);        /* mov [ebp-0x98], eax */
            ii(0x100d_1344, 2);  jmp(0x100d_1350, 0xa); goto l_0x100d_1350;/* jmp 0x100d1350 */
        l_0x100d_1346:
            ii(0x100d_1346, 10);  mov(memd[ss, ebp - 152], 0);         /* mov dword [ebp-0x98], 0x0 */
        l_0x100d_1350:
            ii(0x100d_1350, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1353, 3);  mov(eax, memd[ds, eax + 118]);        /* mov eax, [eax+0x76] */
            ii(0x100d_1356, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x100d_1359, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100d_135d, 2);  if(jz(0x100d_1376, 0x17)) goto l_0x100d_1376;/* jz 0x100d1376 */
            ii(0x100d_135f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_1361, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x100d_1364, 5);  call(Definitions.my_dtor_d3, 0x69ca); /* call 0x100d7d33 */
            ii(0x100d_1369, 5);  call(Definitions.sys_delete, 0x9_4bf6);/* call 0x10165f64 */
            ii(0x100d_136e, 6);  mov(memd[ss, ebp - 148], eax);        /* mov [ebp-0x94], eax */
            ii(0x100d_1374, 2);  jmp(0x100d_1380, 0xa); goto l_0x100d_1380;/* jmp 0x100d1380 */
        l_0x100d_1376:
            ii(0x100d_1376, 10);  mov(memd[ss, ebp - 148], 0);         /* mov dword [ebp-0x94], 0x0 */
        l_0x100d_1380:
            ii(0x100d_1380, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1383, 3);  mov(eax, memd[ds, eax + 122]);        /* mov eax, [eax+0x7a] */
            ii(0x100d_1386, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100d_1389, 4);  cmp(memd[ss, ebp - 60], 0);           /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x100d_138d, 2);  if(jz(0x100d_13a6, 0x17)) goto l_0x100d_13a6;/* jz 0x100d13a6 */
            ii(0x100d_138f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_1391, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x100d_1394, 5);  call(Definitions.my_dtor_d3, 0x699a); /* call 0x100d7d33 */
            ii(0x100d_1399, 5);  call(Definitions.sys_delete, 0x9_4bc6);/* call 0x10165f64 */
            ii(0x100d_139e, 6);  mov(memd[ss, ebp - 144], eax);        /* mov [ebp-0x90], eax */
            ii(0x100d_13a4, 2);  jmp(0x100d_13b0, 0xa); goto l_0x100d_13b0;/* jmp 0x100d13b0 */
        l_0x100d_13a6:
            ii(0x100d_13a6, 10);  mov(memd[ss, ebp - 144], 0);         /* mov dword [ebp-0x90], 0x0 */
        l_0x100d_13b0:
            ii(0x100d_13b0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_13b3, 3);  mov(eax, memd[ds, eax + 126]);        /* mov eax, [eax+0x7e] */
            ii(0x100d_13b6, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x100d_13b9, 4);  cmp(memd[ss, ebp - 56], 0);           /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100d_13bd, 2);  if(jz(0x100d_13d6, 0x17)) goto l_0x100d_13d6;/* jz 0x100d13d6 */
            ii(0x100d_13bf, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_13c1, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_13c4, 5);  call(Definitions.my_dtor_d3, 0x696a); /* call 0x100d7d33 */
            ii(0x100d_13c9, 5);  call(Definitions.sys_delete, 0x9_4b96);/* call 0x10165f64 */
            ii(0x100d_13ce, 6);  mov(memd[ss, ebp - 140], eax);        /* mov [ebp-0x8c], eax */
            ii(0x100d_13d4, 2);  jmp(0x100d_13e0, 0xa); goto l_0x100d_13e0;/* jmp 0x100d13e0 */
        l_0x100d_13d6:
            ii(0x100d_13d6, 10);  mov(memd[ss, ebp - 140], 0);         /* mov dword [ebp-0x8c], 0x0 */
        l_0x100d_13e0:
            ii(0x100d_13e0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_13e3, 6);  mov(eax, memd[ds, eax + 130]);        /* mov eax, [eax+0x82] */
            ii(0x100d_13e9, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_13ec, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100d_13f0, 2);  if(jz(0x100d_1409, 0x17)) goto l_0x100d_1409;/* jz 0x100d1409 */
            ii(0x100d_13f2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_13f4, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_13f7, 5);  call(Definitions.my_dtor_d3, 0x6937); /* call 0x100d7d33 */
            ii(0x100d_13fc, 5);  call(Definitions.sys_delete, 0x9_4b63);/* call 0x10165f64 */
            ii(0x100d_1401, 6);  mov(memd[ss, ebp - 136], eax);        /* mov [ebp-0x88], eax */
            ii(0x100d_1407, 2);  jmp(0x100d_1413, 0xa); goto l_0x100d_1413;/* jmp 0x100d1413 */
        l_0x100d_1409:
            ii(0x100d_1409, 10);  mov(memd[ss, ebp - 136], 0);         /* mov dword [ebp-0x88], 0x0 */
        l_0x100d_1413:
            ii(0x100d_1413, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_1415, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1418, 3);  add(eax, 0x3a);                       /* add eax, 0x3a */
            ii(0x100d_141b, 5);  call(0x1008_8b04, -0x4_891c);         /* call 0x10088b04 */
            ii(0x100d_1420, 3);  sub(eax, 0x3a);                       /* sub eax, 0x3a */
            ii(0x100d_1423, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_1426, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_142b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_142e, 5);  call(0x100d_6999, 0x5566);            /* call 0x100d6999 */
            ii(0x100d_1433, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_1436, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1439, 3);  mov(memd[ss, ebp - 124], eax);        /* mov [ebp-0x7c], eax */
            ii(0x100d_143c, 3);  mov(eax, memd[ss, ebp - 124]);        /* mov eax, [ebp-0x7c] */
            ii(0x100d_143f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_1441, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_1442, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_1443, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_1444, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_1445, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_1446, 1);  ret();                                /* ret */
        }
    }
}
