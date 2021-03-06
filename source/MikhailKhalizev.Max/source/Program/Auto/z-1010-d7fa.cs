using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_d7fa-e6d7c144")]
        public void Method_1010_d7fa()
        {
            ii(0x1010_d7fa, 5);  push(0x44);                           /* push 0x44 */
            ii(0x1010_d7ff, 5);  call(Definitions.sys_check_available_stack_size, 0x5_854e);/* call 0x10165d52 */
            ii(0x1010_d804, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_d805, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_d806, 1);  push(edx);                            /* push edx */
            ii(0x1010_d807, 1);  push(esi);                            /* push esi */
            ii(0x1010_d808, 1);  push(edi);                            /* push edi */
            ii(0x1010_d809, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_d80a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_d80c, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x1010_d812, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_d815, 7);  mov(memd[ss, ebp - 8], 0xc);          /* mov dword [ebp-0x8], 0xc */
        l_0x1010_d81c:
            ii(0x1010_d81c, 3);  dec(memd[ss, ebp - 8]);               /* dec dword [ebp-0x8] */
            ii(0x1010_d81f, 5);  cmp(memw[ss, ebp - 8], -1 /* 0xff */);/* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_d824, 2);  if(jz(0x1010_d869, 0x43)) goto l_0x1010_d869;/* jz 0x1010d869 */
            ii(0x1010_d826, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_d82a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_d82d, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1010_d830, 4);  cmp(memd[ds, eax + 32], 0);           /* cmp dword [eax+0x20], 0x0 */
            ii(0x1010_d834, 2);  if(jz(0x1010_d867, 0x31)) goto l_0x1010_d867;/* jz 0x1010d867 */
            ii(0x1010_d836, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_d83a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_d83d, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1010_d840, 3);  mov(eax, memd[ds, eax + 32]);         /* mov eax, [eax+0x20] */
            ii(0x1010_d843, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_d846, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_d84a, 2);  if(jz(0x1010_d860, 0x14)) goto l_0x1010_d860;/* jz 0x1010d860 */
            ii(0x1010_d84c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_d84e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_d851, 5);  call(Definitions.my_dtor_d2, -0x3_f31e);/* call 0x100ce538 */
            ii(0x1010_d856, 5);  call(Definitions.sys_delete, 0x5_8709);/* call 0x10165f64 */
            ii(0x1010_d85b, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_d85e, 2);  jmp(0x1010_d867, 7); goto l_0x1010_d867;/* jmp 0x1010d867 */
        l_0x1010_d860:
            ii(0x1010_d860, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_d867:
            ii(0x1010_d867, 2);  jmp(0x1010_d81c, -0x4d); goto l_0x1010_d81c;/* jmp 0x1010d81c */
        l_0x1010_d869:
            ii(0x1010_d869, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_d86c, 4);  cmp(memd[ds, eax + 28], 0);           /* cmp dword [eax+0x1c], 0x0 */
            ii(0x1010_d870, 2);  if(jz(0x1010_d89c, 0x2a)) goto l_0x1010_d89c;/* jz 0x1010d89c */
            ii(0x1010_d872, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_d875, 3);  mov(eax, memd[ds, eax + 28]);         /* mov eax, [eax+0x1c] */
            ii(0x1010_d878, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_d87b, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_d87f, 2);  if(jz(0x1010_d895, 0x14)) goto l_0x1010_d895;/* jz 0x1010d895 */
            ii(0x1010_d881, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_d883, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_d886, 5);  call(Definitions.my_dtor_d3, -0x3_5b58);/* call 0x100d7d33 */
            ii(0x1010_d88b, 5);  call(Definitions.sys_delete, 0x5_86d4);/* call 0x10165f64 */
            ii(0x1010_d890, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_d893, 2);  jmp(0x1010_d89c, 7); goto l_0x1010_d89c;/* jmp 0x1010d89c */
        l_0x1010_d895:
            ii(0x1010_d895, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1010_d89c:
            ii(0x1010_d89c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_d89f, 4);  cmp(memd[ds, eax + 20], 0);           /* cmp dword [eax+0x14], 0x0 */
            ii(0x1010_d8a3, 2);  if(jz(0x1010_d8cf, 0x2a)) goto l_0x1010_d8cf;/* jz 0x1010d8cf */
            ii(0x1010_d8a5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_d8a8, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x1010_d8ab, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_d8ae, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1010_d8b2, 2);  if(jz(0x1010_d8c8, 0x14)) goto l_0x1010_d8c8;/* jz 0x1010d8c8 */
            ii(0x1010_d8b4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_d8b6, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_d8b9, 5);  call(Definitions.my_dtor_d3, -0x3_5b8b);/* call 0x100d7d33 */
            ii(0x1010_d8be, 5);  call(Definitions.sys_delete, 0x5_86a1);/* call 0x10165f64 */
            ii(0x1010_d8c3, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_d8c6, 2);  jmp(0x1010_d8cf, 7); goto l_0x1010_d8cf;/* jmp 0x1010d8cf */
        l_0x1010_d8c8:
            ii(0x1010_d8c8, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1010_d8cf:
            ii(0x1010_d8cf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_d8d2, 4);  cmp(memd[ds, eax + 24], 0);           /* cmp dword [eax+0x18], 0x0 */
            ii(0x1010_d8d6, 2);  if(jz(0x1010_d902, 0x2a)) goto l_0x1010_d902;/* jz 0x1010d902 */
            ii(0x1010_d8d8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_d8db, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1010_d8de, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_d8e1, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1010_d8e5, 2);  if(jz(0x1010_d8fb, 0x14)) goto l_0x1010_d8fb;/* jz 0x1010d8fb */
            ii(0x1010_d8e7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_d8e9, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_d8ec, 5);  call(Definitions.my_dtor_d3, -0x3_5bbe);/* call 0x100d7d33 */
            ii(0x1010_d8f1, 5);  call(Definitions.sys_delete, 0x5_866e);/* call 0x10165f64 */
            ii(0x1010_d8f6, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1010_d8f9, 2);  jmp(0x1010_d902, 7); goto l_0x1010_d902;/* jmp 0x1010d902 */
        l_0x1010_d8fb:
            ii(0x1010_d8fb, 7);  mov(memd[ss, ebp - 40], 0);           /* mov dword [ebp-0x28], 0x0 */
        l_0x1010_d902:
            ii(0x1010_d902, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_d904, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_d905, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_d906, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_d907, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_d908, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_d909, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_d90a, 1);  ret();                                /* ret */
        }
    }
}
