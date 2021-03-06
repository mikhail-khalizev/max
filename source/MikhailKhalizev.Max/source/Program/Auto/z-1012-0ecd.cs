using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0ecd-18554800")]
        public void Method_1012_0ecd()
        {
            ii(0x1012_0ecd, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1012_0ed2, 5);  call(Definitions.sys_check_available_stack_size, 0x4_4e7b);/* call 0x10165d52 */
            ii(0x1012_0ed7, 1);  push(esi);                            /* push esi */
            ii(0x1012_0ed8, 1);  push(edi);                            /* push edi */
            ii(0x1012_0ed9, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_0eda, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_0edc, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1012_0ee2, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_0ee5, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1012_0ee8, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1012_0eeb, 3);  mov(memb[ss, ebp - 4], cl);           /* mov [ebp-0x4], cl */
            ii(0x1012_0eee, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0ef2, 3);  imul(eax, eax, 0x16);                 /* imul eax, eax, 0x16 */
            ii(0x1012_0ef5, 5);  mov(edx, 0x101c_538c);                /* mov edx, 0x101c538c */
            ii(0x1012_0efa, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1012_0efc, 3);  mov(memd[ss, ebp - 20], edx);         /* mov [ebp-0x14], edx */
            ii(0x1012_0eff, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_0f02, 4);  mov(ax, memw[ds, eax + 12]);          /* mov ax, [eax+0xc] */
            ii(0x1012_0f06, 5);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1012_0f0b, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_0f0e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_0f11, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1012_0f15, 3);  sub(eax, 0x12);                       /* sub eax, 0x12 */
            ii(0x1012_0f18, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1012_0f1b, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1012_0f1f, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_0f22, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1012_0f25, 3);  lea(ebx, memd[ds, eax + edx]);        /* lea ebx, [eax+edx] */
            ii(0x1012_0f28, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1012_0f2c, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_0f2f, 3);  imul(edx, memd[ds, eax]);             /* imul edx, [eax] */
            ii(0x1012_0f32, 2);  add(ebx, edx);                        /* add ebx, edx */
            ii(0x1012_0f34, 3);  mov(memd[ss, ebp - 32], ebx);         /* mov [ebp-0x20], ebx */
            ii(0x1012_0f37, 5);  cmp(memw[ss, ebp - 8], 0);            /* cmp word [ebp-0x8], 0x0 */
            ii(0x1012_0f3c, 2);  if(jnz(0x1012_0f68, 0x2a)) goto l_0x1012_0f68;/* jnz 0x10120f68 */
            ii(0x1012_0f3e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_0f41, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1012_0f44, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_0f46, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_0f4b, 1);  push(eax);                            /* push eax */
            ii(0x1012_0f4c, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_0f4f, 2);  mov(ecx, memd[ds, eax]);              /* mov ecx, [eax] */
            ii(0x1012_0f51, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x1012_0f56, 5);  mov(edx, 0x25);                       /* mov edx, 0x25 */
            ii(0x1012_0f5b, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1012_0f5e, 5);  call(/* sys */ 0x1016_ad78, 0x4_9e15);/* call 0x1016ad78 */
            ii(0x1012_0f63, 5);  jmp(0x1012_1072, 0x10a); goto l_0x1012_1072;/* jmp 0x10121072 */
        l_0x1012_0f68:
            ii(0x1012_0f68, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_0f6b, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x1012_0f6f, 2);  if(jle(0x1012_0f77, 6)) goto l_0x1012_0f77;/* jle 0x10120f77 */
            ii(0x1012_0f71, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_0f74, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1012_0f77:
            ii(0x1012_0f77, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_0f7a, 3);  sub(memd[ss, ebp - 16], eax);         /* sub [ebp-0x10], eax */
            ii(0x1012_0f7d, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1012_0f81, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_0f85, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1012_0f87, 3);  imul(edx, eax, 0x23);                 /* imul edx, eax, 0x23 */
            ii(0x1012_0f8a, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1012_0f8e, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_0f90, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_0f93, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1012_0f95, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_0f98, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1012_0f9c, 3);  imul(edx, edx, 0x23);                 /* imul edx, edx, 0x23 */
            ii(0x1012_0f9f, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1012_0fa3, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_0fa5, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_0fa8, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1012_0faa, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_0fad, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_0fb0, 3);  sub(memd[ss, ebp - 12], eax);         /* sub [ebp-0xc], eax */
            ii(0x1012_0fb3, 2);  push(0);                              /* push 0x0 */
            ii(0x1012_0fb5, 2);  push(4);                              /* push 0x4 */
            ii(0x1012_0fb7, 2);  push(0x24);                           /* push 0x24 */
            ii(0x1012_0fb9, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1012_0fbb, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1012_0fbd, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x1012_0fc0, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1012_0fc2, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1012_0fc5, 5);  call(/* sys */ 0x1016_a68c, 0x4_96c2);/* call 0x1016a68c */
            ii(0x1012_0fca, 5);  cmp(memw[ss, ebp - 16], 0);           /* cmp word [ebp-0x10], 0x0 */
            ii(0x1012_0fcf, 2);  if(jz(0x1012_0ff1, 0x20)) goto l_0x1012_0ff1;/* jz 0x10120ff1 */
            ii(0x1012_0fd1, 2);  push(2);                              /* push 0x2 */
            ii(0x1012_0fd3, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_0fd6, 2);  mov(ecx, memd[ds, eax]);              /* mov ecx, [eax] */
            ii(0x1012_0fd8, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1012_0fdd, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1012_0fe1, 3);  mov(esi, memd[ss, ebp - 32]);         /* mov esi, [ebp-0x20] */
            ii(0x1012_0fe4, 1);  inc(esi);                             /* inc esi */
            ii(0x1012_0fe5, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_0fe8, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1012_0fea, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1012_0fec, 5);  call(/* sys */ 0x1016_ad78, 0x4_9d87);/* call 0x1016ad78 */
        l_0x1012_0ff1:
            ii(0x1012_0ff1, 5);  cmp(memw[ss, ebp - 12], 0);           /* cmp word [ebp-0xc], 0x0 */
            ii(0x1012_0ff6, 2);  if(jz(0x1012_101c, 0x24)) goto l_0x1012_101c;/* jz 0x1012101c */
            ii(0x1012_0ff8, 2);  push(1);                              /* push 0x1 */
            ii(0x1012_0ffa, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_0ffd, 2);  mov(ecx, memd[ds, eax]);              /* mov ecx, [eax] */
            ii(0x1012_0fff, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1012_1004, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1012_1008, 3);  mov(esi, memd[ss, ebp - 32]);         /* mov esi, [ebp-0x20] */
            ii(0x1012_100b, 1);  inc(esi);                             /* inc esi */
            ii(0x1012_100c, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_100f, 2);  add(esi, memd[ds, eax]);              /* add esi, [eax] */
            ii(0x1012_1011, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_1015, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1012_1017, 5);  call(/* sys */ 0x1016_ad78, 0x4_9d5c);/* call 0x1016ad78 */
        l_0x1012_101c:
            ii(0x1012_101c, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1012_1020, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_1024, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1012_1026, 3);  cmp(eax, 0x23);                       /* cmp eax, 0x23 */
            ii(0x1012_1029, 2);  if(jge(0x1012_1072, 0x47)) goto l_0x1012_1072;/* jge 0x10121072 */
            ii(0x1012_102b, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_102e, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1012_1031, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_1033, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_1038, 1);  push(eax);                            /* push eax */
            ii(0x1012_1039, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_103c, 2);  mov(ecx, memd[ds, eax]);              /* mov ecx, [eax] */
            ii(0x1012_103e, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1012_1043, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1047, 5);  mov(edx, 0x23);                       /* mov edx, 0x23 */
            ii(0x1012_104c, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1012_104e, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_1050, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1012_1054, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1012_1056, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_1058, 3);  mov(esi, memd[ss, ebp - 32]);         /* mov esi, [ebp-0x20] */
            ii(0x1012_105b, 1);  inc(esi);                             /* inc esi */
            ii(0x1012_105c, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_105f, 2);  add(esi, memd[ds, eax]);              /* add esi, [eax] */
            ii(0x1012_1061, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_1065, 2);  add(esi, eax);                        /* add esi, eax */
            ii(0x1012_1067, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1012_106b, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1012_106d, 5);  call(/* sys */ 0x1016_ad78, 0x4_9d06);/* call 0x1016ad78 */
        l_0x1012_1072:
            ii(0x1012_1072, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_1074, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_1075, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_1076, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_1077, 1);  ret();                                /* ret */
        }
    }
}
