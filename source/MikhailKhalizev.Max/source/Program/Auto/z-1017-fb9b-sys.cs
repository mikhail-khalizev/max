using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_fb9b-9b876677")]
        public void /* sys */ Method_1017_fb9b()
        {
            ii(0x1017_fb9b, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_fb9c, 1);  push(esi);                            /* push esi */
            ii(0x1017_fb9d, 1);  push(edi);                            /* push edi */
            ii(0x1017_fb9e, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_fb9f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1017_fba1, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x1017_fba7, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1017_fbaa, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x1017_fbad, 3);  mov(memd[ss, ebp - 32], ebx);         /* mov [ebp-0x20], ebx */
            ii(0x1017_fbb0, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1017_fbb7, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1017_fbbe, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1017_fbc1, 6);  mov(memw[ds, eax + 4], 0);            /* mov word [eax+0x4], 0x0 */
            ii(0x1017_fbc7, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1017_fbca, 6);  mov(memd[ds, eax], 0);                /* mov dword [eax], 0x0 */
            ii(0x1017_fbd0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1017_fbd3, 6);  mov(memd[ds, eax], 0);                /* mov dword [eax], 0x0 */
            ii(0x1017_fbd9, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1017_fbdc, 6);  mov(memd[ds, eax], 0);                /* mov dword [eax], 0x0 */
            ii(0x1017_fbe2, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1017_fbe9, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1017_fbec, 1);  push(eax);                            /* push eax */
            ii(0x1017_fbed, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1017_fbf0, 1);  push(eax);                            /* push eax */
            ii(0x1017_fbf1, 2);  push(0x20);                           /* push 0x20 */
            ii(0x1017_fbf3, 5);  call(/* sys */ 0x1019_52e4, 0x1_56ec);/* call 0x101952e4 */
            ii(0x1017_fbf8, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1017_fbfb, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_fbfd, 2);  if(jz(0x1017_fc0b, 0xc)) goto l_0x1017_fc0b;/* jz 0x1017fc0b */
            ii(0x1017_fbff, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1017_fc06, 5);  jmp(0x1017_fcaf, 0xa4); goto l_0x1017_fcaf;/* jmp 0x1017fcaf */
        l_0x1017_fc0b:
            ii(0x1017_fc0b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_fc0d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1017_fc10, 4);  mov(memw[ss, ebp - 40], ax);          /* mov [ebp-0x28], ax */
            ii(0x1017_fc14, 3);  mov(memd[ss, ebp - 44], edx);         /* mov [ebp-0x2c], edx */
            ii(0x1017_fc17, 4);  lgs(edx, memd[ss, ebp - 44]);         /* lgs edx, [ebp-0x2c] */
            ii(0x1017_fc1b, 7);  mov(memd[gs, edx], 0x1000);           /* mov dword [gs:edx], 0x1000 */
            ii(0x1017_fc22, 3);  push(memd[ss, ebp - 4]);              /* push dword [ebp-0x4] */
            ii(0x1017_fc25, 5);  call(/* sys */ 0x1019_5353, 0x1_5729);/* call 0x10195353 */
            ii(0x1017_fc2a, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1017_fc2d, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1017_fc30, 2);  push(0x10);                           /* push 0x10 */
            ii(0x1017_fc32, 3);  mov(ebx, memd[ss, ebp - 40]);         /* mov ebx, [ebp-0x28] */
            ii(0x1017_fc35, 3);  mov(esi, memd[ss, ebp - 44]);         /* mov esi, [ebp-0x2c] */
            ii(0x1017_fc38, 2);  mov(ecx, ds);                         /* mov ecx, ds */
            ii(0x1017_fc3a, 5);  mov(edx, 0x1020_a1e4);                /* mov edx, 0x1020a1e4 */
            ii(0x1017_fc3f, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1017_fc41, 2);  mov(ecx, edx);                        /* mov ecx, edx */
            ii(0x1017_fc43, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_fc45, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1017_fc47, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1017_fc49, 2);  mov(ebx, esi);                        /* mov ebx, esi */
            ii(0x1017_fc4b, 5);  call(/* sys */ 0x1017_d4ca, -0x2786); /* call 0x1017d4ca */
            ii(0x1017_fc50, 3);  push(memd[ss, ebp - 4]);              /* push dword [ebp-0x4] */
            ii(0x1017_fc53, 3);  push(memd[ss, ebp - 12]);             /* push dword [ebp-0xc] */
            ii(0x1017_fc56, 5);  call(/* sys */ 0x1019_5325, 0x1_56ca);/* call 0x10195325 */
            ii(0x1017_fc5b, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1017_fc5e, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1017_fc62, 2);  if(jnz(0x1017_fca8, 0x44)) goto l_0x1017_fca8;/* jnz 0x1017fca8 */
            ii(0x1017_fc64, 9);  and(memw[ds, 0x1020_a1f0], 0xf000);   /* and word [0x1020a1f0], 0xf000 */
            ii(0x1017_fc6d, 6);  push(memd[ds, 0x1020_a1f0]);          /* push dword [0x1020a1f0] */
            ii(0x1017_fc73, 5);  call(/* sys */ 0x1019_540c, 0x1_5794);/* call 0x1019540c */
            ii(0x1017_fc78, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1017_fc7b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1017_fc7e, 5);  mov(eax, memd[ds, 0x1020_a1f0]);      /* mov eax, [0x1020a1f0] */
            ii(0x1017_fc83, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1017_fc86, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_fc88, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1017_fc8b, 3);  mov(ebx, memd[ss, ebp - 36]);         /* mov ebx, [ebp-0x24] */
            ii(0x1017_fc8e, 4);  mov(memw[ds, ebx + 4], ax);           /* mov [ebx+0x4], ax */
            ii(0x1017_fc92, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1017_fc95, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1017_fc97, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1017_fc9a, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1017_fc9d, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
            ii(0x1017_fc9f, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1017_fca6, 2);  jmp(0x1017_fcaf, 7); goto l_0x1017_fcaf;/* jmp 0x1017fcaf */
        l_0x1017_fca8:
            ii(0x1017_fca8, 7);  mov(memd[ss, ebp - 28], 5);           /* mov dword [ebp-0x1c], 0x5 */
        l_0x1017_fcaf:
            ii(0x1017_fcaf, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1017_fcb2, 1);  leave();                              /* leave */
            ii(0x1017_fcb3, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_fcb4, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_fcb5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_fcb6, 1);  ret();                                /* ret */
        }
    }
}
