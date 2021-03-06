using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_10e7-59ee38a2")]
        public void Method_1012_10e7()
        {
            ii(0x1012_10e7, 5);  push(0x44);                           /* push 0x44 */
            ii(0x1012_10ec, 5);  call(Definitions.sys_check_available_stack_size, 0x4_4c61);/* call 0x10165d52 */
            ii(0x1012_10f1, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_10f2, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_10f3, 1);  push(esi);                            /* push esi */
            ii(0x1012_10f4, 1);  push(edi);                            /* push edi */
            ii(0x1012_10f5, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_10f6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_10f8, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1012_10fe, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_1101, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1012_1104, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_1108, 3);  imul(eax, eax, 0x16);                 /* imul eax, eax, 0x16 */
            ii(0x1012_110b, 5);  mov(edx, 0x101c_538c);                /* mov edx, 0x101c538c */
            ii(0x1012_1110, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1012_1112, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1012_1115, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_1118, 4);  mov(ax, memw[ds, eax + 12]);          /* mov ax, [eax+0xc] */
            ii(0x1012_111c, 5);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1012_1121, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_1124, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_1127, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1012_112b, 3);  sub(eax, 0x12);                       /* sub eax, 0x12 */
            ii(0x1012_112e, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_1131, 4);  movsx(ebx, memw[ss, ebp - 20]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x1012_1135, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_1138, 3);  mov(eax, memd[ds, edx + 18]);         /* mov eax, [edx+0x12] */
            ii(0x1012_113b, 2);  add(ebx, eax);                        /* add ebx, eax */
            ii(0x1012_113d, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1012_1141, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_1144, 3);  imul(edx, memd[ds, eax]);             /* imul edx, [eax] */
            ii(0x1012_1147, 2);  add(ebx, edx);                        /* add ebx, edx */
            ii(0x1012_1149, 3);  mov(memd[ss, ebp - 24], ebx);         /* mov [ebp-0x18], ebx */
            ii(0x1012_114c, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1012_1150, 3);  imul(edx, edx, 0x23);                 /* imul edx, edx, 0x23 */
            ii(0x1012_1153, 5);  mov(ebx, 0x64);                       /* mov ebx, 0x64 */
            ii(0x1012_1158, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_115a, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_115d, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1012_115f, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1012_1162, 5);  mov(eax, 0x23);                       /* mov eax, 0x23 */
            ii(0x1012_1167, 3);  sub(eax, memd[ss, ebp - 28]);         /* sub eax, [ebp-0x1c] */
            ii(0x1012_116a, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1012_116d, 2);  push(0);                              /* push 0x0 */
            ii(0x1012_116f, 2);  push(4);                              /* push 0x4 */
            ii(0x1012_1171, 2);  push(0x24);                           /* push 0x24 */
            ii(0x1012_1173, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1012_1175, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1012_1177, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_117a, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1012_117c, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_117f, 5);  call(/* sys */ 0x1016_a68c, 0x4_9508);/* call 0x1016a68c */
            ii(0x1012_1184, 5);  cmp(memw[ss, ebp - 28], 0);           /* cmp word [ebp-0x1c], 0x0 */
            ii(0x1012_1189, 2);  if(jz(0x1012_11ab, 0x20)) goto l_0x1012_11ab;/* jz 0x101211ab */
            ii(0x1012_118b, 2);  push(1);                              /* push 0x1 */
            ii(0x1012_118d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_1190, 2);  mov(ecx, memd[ds, eax]);              /* mov ecx, [eax] */
            ii(0x1012_1192, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1012_1197, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1012_119b, 3);  mov(esi, memd[ss, ebp - 24]);         /* mov esi, [ebp-0x18] */
            ii(0x1012_119e, 1);  inc(esi);                             /* inc esi */
            ii(0x1012_119f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_11a2, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1012_11a4, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1012_11a6, 5);  call(/* sys */ 0x1016_ad78, 0x4_9bcd);/* call 0x1016ad78 */
        l_0x1012_11ab:
            ii(0x1012_11ab, 5);  cmp(memw[ss, ebp - 32], 0);           /* cmp word [ebp-0x20], 0x0 */
            ii(0x1012_11b0, 2);  if(jz(0x1012_11e2, 0x30)) goto l_0x1012_11e2;/* jz 0x101211e2 */
            ii(0x1012_11b2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_11b5, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1012_11b8, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_11ba, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_11bf, 1);  push(eax);                            /* push eax */
            ii(0x1012_11c0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_11c3, 2);  mov(ecx, memd[ds, eax]);              /* mov ecx, [eax] */
            ii(0x1012_11c5, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1012_11ca, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1012_11ce, 3);  mov(esi, memd[ss, ebp - 24]);         /* mov esi, [ebp-0x18] */
            ii(0x1012_11d1, 1);  inc(esi);                             /* inc esi */
            ii(0x1012_11d2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_11d5, 2);  add(esi, memd[ds, eax]);              /* add esi, [eax] */
            ii(0x1012_11d7, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_11db, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1012_11dd, 5);  call(/* sys */ 0x1016_ad78, 0x4_9b96);/* call 0x1016ad78 */
        l_0x1012_11e2:
            ii(0x1012_11e2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_11e4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_11e5, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_11e6, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_11e7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_11e8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_11e9, 1);  ret();                                /* ret */
        }
    }
}
