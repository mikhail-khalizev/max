using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_7f78-3eefa7bd")]
        public void Method_1015_7f78()
        {
            ii(0x1015_7f78, 5); push(0x28);                             /* push 0x28 */
            ii(0x1015_7f7d, 5); call(Definitions.sys_check_available_stack_size, 0xddd0); /* call 0x10165d52 */
            ii(0x1015_7f82, 1); push(ebx);                              /* push ebx */
            ii(0x1015_7f83, 1); push(ecx);                              /* push ecx */
            ii(0x1015_7f84, 1); push(esi);                              /* push esi */
            ii(0x1015_7f85, 1); push(edi);                              /* push edi */
            ii(0x1015_7f86, 1); push(ebp);                              /* push ebp */
            ii(0x1015_7f87, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_7f89, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_7f8f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_7f92, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_7f95, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_7f98, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1015_7f9b, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1015_7fa0, 5); call(0x100f_448c, -0x6_3b19);           /* call 0x100f448c */
            ii(0x1015_7fa5, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_7fa8, 4); cmp(memb[ds, eax + 92], 0);             /* cmp byte [eax+0x5c], 0x0 */
            ii(0x1015_7fac, 2); if(jnz(0x1015_7fb4, 6)) goto l_0x1015_7fb4; /* jnz 0x10157fb4 */
            ii(0x1015_7fae, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_7fb2, 2); jmp(0x1015_7fb8, 4); goto l_0x1015_7fb8; /* jmp 0x10157fb8 */
        l_0x1015_7fb4:
            ii(0x1015_7fb4, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_7fb8:
            ii(0x1015_7fb8, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1015_7fbb, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1015_7fbe, 3); mov(memb[ds, edx + 92], al);            /* mov [edx+0x5c], al */
            ii(0x1015_7fc1, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_7fc4, 4); cmp(memb[ds, eax + 61], 0xc);           /* cmp byte [eax+0x3d], 0xc */
            ii(0x1015_7fc8, 2); if(jnz(0x1015_7fd9, 0xf)) goto l_0x1015_7fd9; /* jnz 0x10157fd9 */
            ii(0x1015_7fca, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1015_7fcf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_7fd1, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_7fd4, 5); call(0x1016_3053, 0xb07a);              /* call 0x10163053 */
        l_0x1015_7fd9:
            ii(0x1015_7fd9, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_7fdc, 4); cmp(memb[ds, eax + 92], 0);             /* cmp byte [eax+0x5c], 0x0 */
            ii(0x1015_7fe0, 2); if(jz(0x1015_7fec, 0xa)) goto l_0x1015_7fec; /* jz 0x10157fec */
            ii(0x1015_7fe2, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_7fe5, 5); call(0x100a_9e06, -0xa_e1e4);           /* call 0x100a9e06 */
            ii(0x1015_7fea, 2); jmp(0x1015_7ff4, 8); goto l_0x1015_7ff4; /* jmp 0x10157ff4 */
        l_0x1015_7fec:
            ii(0x1015_7fec, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_7fef, 5); call(0x1015_287d, -0x5777);             /* call 0x1015287d */
        l_0x1015_7ff4:
            ii(0x1015_7ff4, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_7ff7, 5); call(0x1010_094d, -0x5_76af);           /* call 0x1010094d */
            ii(0x1015_7ffc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_7ffe, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_7fff, 1); pop(edi);                               /* pop edi */
            ii(0x1015_8000, 1); pop(esi);                               /* pop esi */
            ii(0x1015_8001, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_8002, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_8003, 1); ret();                                  /* ret */
        }
    }
}
