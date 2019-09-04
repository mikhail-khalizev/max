using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_f8a4-c22f45ac")]
        public void Method_1013_f8a4()
        {
            ii(0x1013_f8a4, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1013_f8a9, 5);  call(Definitions.sys_check_available_stack_size, 0x2_64a4);/* call 0x10165d52 */
            ii(0x1013_f8ae, 1);  push(esi);                            /* push esi */
            ii(0x1013_f8af, 1);  push(edi);                            /* push edi */
            ii(0x1013_f8b0, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_f8b1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_f8b3, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1013_f8b9, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_f8bc, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_f8bf, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1013_f8c2, 3);  mov(memd[ss, ebp - 12], ecx);         /* mov [ebp-0xc], ecx */
            ii(0x1013_f8c5, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1013_f8ca, 1);  push(eax);                            /* push eax */
            ii(0x1013_f8cb, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_f8ce, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x1013_f8d1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_f8d4, 1);  push(eax);                            /* push eax */
            ii(0x1013_f8d5, 4);  movsx(ecx, memw[ss, ebp + 16]);       /* movsx ecx, word [ebp+0x10] */
            ii(0x1013_f8d9, 5);  mov(ebx, StringDefinitions.Attack);   /* mov ebx, 0x101acdc4 */
            ii(0x1013_f8de, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_f8e2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f8e5, 5);  call(0x1013_f4b0, -0x43a);            /* call 0x1013f4b0 */
            ii(0x1013_f8ea, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_f8ed, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x1013_f8f0, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_f8f3, 1);  push(eax);                            /* push eax */
            ii(0x1013_f8f4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f8f7, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x1013_f8fa, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_f8fd, 1);  push(eax);                            /* push eax */
            ii(0x1013_f8fe, 5);  mov(eax, 0x264);                      /* mov eax, 0x264 */
            ii(0x1013_f903, 1);  push(eax);                            /* push eax */
            ii(0x1013_f904, 5);  mov(ecx, 0x264);                      /* mov ecx, 0x264 */
            ii(0x1013_f909, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1013_f90c, 3);  sub(eax, 0x4c);                       /* sub eax, 0x4c */
            ii(0x1013_f90f, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_f912, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_f916, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f919, 3);  add(eax, 0x4c);                       /* add eax, 0x4c */
            ii(0x1013_f91c, 5);  call(0x1013_f629, -0x2f8);            /* call 0x1013f629 */
            ii(0x1013_f921, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_f925, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x1013_f928, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
            ii(0x1013_f92b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f92e, 5);  cmp(memw[ds, eax + 20], 0);           /* cmp word [eax+0x14], 0x0 */
            ii(0x1013_f933, 2);  if(jz(0x1013_f99b, 0x66)) goto l_0x1013_f99b;/* jz 0x1013f99b */
            ii(0x1013_f935, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1013_f93a, 1);  push(eax);                            /* push eax */
            ii(0x1013_f93b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_f93e, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1013_f941, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_f944, 1);  push(eax);                            /* push eax */
            ii(0x1013_f945, 4);  movsx(ecx, memw[ss, ebp + 16]);       /* movsx ecx, word [ebp+0x10] */
            ii(0x1013_f949, 5);  mov(ebx, StringDefinitions.Shots2);   /* mov ebx, 0x101acdcb */
            ii(0x1013_f94e, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_f952, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f955, 5);  call(0x1013_f4b0, -0x4aa);            /* call 0x1013f4b0 */
            ii(0x1013_f95a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_f95d, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1013_f960, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_f963, 1);  push(eax);                            /* push eax */
            ii(0x1013_f964, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f967, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1013_f96a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_f96d, 1);  push(eax);                            /* push eax */
            ii(0x1013_f96e, 5);  mov(eax, 0x266);                      /* mov eax, 0x266 */
            ii(0x1013_f973, 1);  push(eax);                            /* push eax */
            ii(0x1013_f974, 5);  mov(ecx, 0x266);                      /* mov ecx, 0x266 */
            ii(0x1013_f979, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1013_f97c, 3);  sub(eax, 0x4c);                       /* sub eax, 0x4c */
            ii(0x1013_f97f, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_f982, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_f986, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f989, 3);  add(eax, 0x4c);                       /* add eax, 0x4c */
            ii(0x1013_f98c, 5);  call(0x1013_f629, -0x368);            /* call 0x1013f629 */
            ii(0x1013_f991, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_f995, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x1013_f998, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
        l_0x1013_f99b:
            ii(0x1013_f99b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f99e, 5);  cmp(memw[ds, eax + 18], 0);           /* cmp word [eax+0x12], 0x0 */
            ii(0x1013_f9a3, 2);  if(jz(0x1013_fa0b, 0x66)) goto l_0x1013_fa0b;/* jz 0x1013fa0b */
            ii(0x1013_f9a5, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1013_f9aa, 1);  push(eax);                            /* push eax */
            ii(0x1013_f9ab, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_f9ae, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1013_f9b1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_f9b4, 1);  push(eax);                            /* push eax */
            ii(0x1013_f9b5, 4);  movsx(ecx, memw[ss, ebp + 16]);       /* movsx ecx, word [ebp+0x10] */
            ii(0x1013_f9b9, 5);  mov(ebx, StringDefinitions.Range);    /* mov ebx, 0x101acdd1 */
            ii(0x1013_f9be, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_f9c2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f9c5, 5);  call(0x1013_f4b0, -0x51a);            /* call 0x1013f4b0 */
            ii(0x1013_f9ca, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_f9cd, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1013_f9d0, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_f9d3, 1);  push(eax);                            /* push eax */
            ii(0x1013_f9d4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f9d7, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1013_f9da, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_f9dd, 1);  push(eax);                            /* push eax */
            ii(0x1013_f9de, 5);  mov(eax, 0x267);                      /* mov eax, 0x267 */
            ii(0x1013_f9e3, 1);  push(eax);                            /* push eax */
            ii(0x1013_f9e4, 5);  mov(ecx, 0x267);                      /* mov ecx, 0x267 */
            ii(0x1013_f9e9, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1013_f9ec, 3);  sub(eax, 0x4c);                       /* sub eax, 0x4c */
            ii(0x1013_f9ef, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_f9f2, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_f9f6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f9f9, 3);  add(eax, 0x4c);                       /* add eax, 0x4c */
            ii(0x1013_f9fc, 5);  call(0x1013_f629, -0x3d8);            /* call 0x1013f629 */
            ii(0x1013_fa01, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_fa05, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x1013_fa08, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
        l_0x1013_fa0b:
            ii(0x1013_fa0b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_fa0e, 5);  cmp(memw[ds, eax + 27], 0);           /* cmp word [eax+0x1b], 0x0 */
            ii(0x1013_fa13, 2);  if(jz(0x1013_fa7b, 0x66)) goto l_0x1013_fa7b;/* jz 0x1013fa7b */
            ii(0x1013_fa15, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1013_fa1a, 1);  push(eax);                            /* push eax */
            ii(0x1013_fa1b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_fa1e, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1013_fa21, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_fa24, 1);  push(eax);                            /* push eax */
            ii(0x1013_fa25, 4);  movsx(ecx, memw[ss, ebp + 16]);       /* movsx ecx, word [ebp+0x10] */
            ii(0x1013_fa29, 5);  mov(ebx, StringDefinitions.Ammo2);    /* mov ebx, 0x101acdd7 */
            ii(0x1013_fa2e, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_fa32, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_fa35, 5);  call(0x1013_f4b0, -0x58a);            /* call 0x1013f4b0 */
            ii(0x1013_fa3a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_fa3d, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1013_fa40, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_fa43, 1);  push(eax);                            /* push eax */
            ii(0x1013_fa44, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_fa47, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1013_fa4a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_fa4d, 1);  push(eax);                            /* push eax */
            ii(0x1013_fa4e, 5);  mov(eax, 0x268);                      /* mov eax, 0x268 */
            ii(0x1013_fa53, 1);  push(eax);                            /* push eax */
            ii(0x1013_fa54, 5);  mov(ecx, 0x268);                      /* mov ecx, 0x268 */
            ii(0x1013_fa59, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1013_fa5c, 3);  sub(eax, 0x4c);                       /* sub eax, 0x4c */
            ii(0x1013_fa5f, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_fa62, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_fa66, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_fa69, 3);  add(eax, 0x4c);                       /* add eax, 0x4c */
            ii(0x1013_fa6c, 5);  call(0x1013_f629, -0x448);            /* call 0x1013f629 */
            ii(0x1013_fa71, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_fa75, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x1013_fa78, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
        l_0x1013_fa7b:
            ii(0x1013_fa7b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_fa7e, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_fa81, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_fa84, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_fa86, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_fa87, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_fa88, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_fa89, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
