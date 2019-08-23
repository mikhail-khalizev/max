using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_19b8-93adcff6")]
        public void Method_1010_19b8()
        {
            ii(0x1010_19b8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_19bd, 5); calld(Definitions.sys_check_available_stack_size, 0x6_4390); /* call 0x10165d52 */
            ii(0x1010_19c2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_19c3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_19c4, 1); pushd(edx);                             /* push edx */
            ii(0x1010_19c5, 1); pushd(esi);                             /* push esi */
            ii(0x1010_19c6, 1); pushd(edi);                             /* push edi */
            ii(0x1010_19c7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_19c8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_19ca, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_19d0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_19d3, 5); mov(eax, 0x57);                         /* mov eax, 0x57 */
            ii(0x1010_19d8, 5); calld(0x1007_5fdc, -0x8_ba01);          /* call 0x10075fdc */
            ii(0x1010_19dd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_19df, 2); if(jzd(0x1010_1a15, 0x34)) goto l_0x1010_1a15; /* jz 0x10101a15 */
            ii(0x1010_19e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_19e4, 5); calld(0x100f_1fef, -0xf9fa);            /* call 0x100f1fef */
            ii(0x1010_19e9, 2); test(al, al);                           /* test al, al */
            ii(0x1010_19eb, 2); if(jnzd(0x1010_1a15, 0x28)) goto l_0x1010_1a15; /* jnz 0x10101a15 */
            ii(0x1010_19ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_19f0, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1010_19f4, 2); if(jnzd(0x1010_19fd, 0x7)) goto l_0x1010_19fd; /* jnz 0x101019fd */
            ii(0x1010_19f6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_19f9, 4); mov(memb_a32[ds, eax + 0x3e], 0x2);     /* mov byte [eax+0x3e], 0x2 */
        l_0x1010_19fd:
            ii(0x1010_19fd, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_1a02, 5); calld(0x1010_1374, -0x693);             /* call 0x10101374 */
            ii(0x1010_1a07, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_1a09, 5); calld(0x100f_fa70, -0x1f9e);            /* call 0x100ffa70 */
            ii(0x1010_1a0e, 5); calld(0x100f_4b16, -0xcefd);            /* call 0x100f4b16 */
            ii(0x1010_1a13, 2); jmpd(0x1010_1a1d, 0x8); goto l_0x1010_1a1d; /* jmp 0x10101a1d */
        l_0x1010_1a15:
            ii(0x1010_1a15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_1a18, 5); calld(0x100f_fa70, -0x1fad);            /* call 0x100ffa70 */
        l_0x1010_1a1d:
            ii(0x1010_1a1d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_1a1f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_1a20, 1); popd(edi);                              /* pop edi */
            ii(0x1010_1a21, 1); popd(esi);                              /* pop esi */
            ii(0x1010_1a22, 1); popd(edx);                              /* pop edx */
            ii(0x1010_1a23, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_1a24, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_1a25, 1); retd();                                 /* ret */
        }
    }
}
