using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9395-f55739c8")]
        public void Method_100a_9395()
        {
            ii(0x100a_9395, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_939a, 5); calld(Definitions.sys_check_available_stack_size, 0xb_c9b3); /* call 0x10165d52 */
            ii(0x100a_939f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_93a0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_93a1, 1); pushd(edx);                             /* push edx */
            ii(0x100a_93a2, 1); pushd(esi);                             /* push esi */
            ii(0x100a_93a3, 1); pushd(edi);                             /* push edi */
            ii(0x100a_93a4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_93a5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_93a7, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_93ad, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x100a_93b2, 5); calld(0x1007_6b90, -0x3_2827);          /* call 0x10076b90 */
            ii(0x100a_93b7, 1); cwde();                                 /* cwde */
            ii(0x100a_93b8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_93ba, 2); if(jnzd(0x100a_93cb, 0xf)) goto l_0x100a_93cb; /* jnz 0x100a93cb */
            ii(0x100a_93bc, 5); mov(eax, 0x101c_81b4);                  /* mov eax, 0x101c81b4 */
            ii(0x100a_93c1, 5); calld(0x1007_6b90, -0x3_2836);          /* call 0x10076b90 */
            ii(0x100a_93c6, 1); cwde();                                 /* cwde */
            ii(0x100a_93c7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_93c9, 2); if(jled(0x100a_93d1, 0x6)) goto l_0x100a_93d1; /* jle 0x100a93d1 */
        l_0x100a_93cb:
            ii(0x100a_93cb, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x100a_93cf, 2); jmpd(0x100a_93d9, 0x8); goto l_0x100a_93d9; /* jmp 0x100a93d9 */
        l_0x100a_93d1:
            ii(0x100a_93d1, 5); mov(al, memb_a32[ds, 0x101c_9448]);     /* mov al, [0x101c9448] */
            ii(0x100a_93d6, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
        l_0x100a_93d9:
            ii(0x100a_93d9, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100a_93dc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_93de, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_93df, 1); popd(edi);                              /* pop edi */
            ii(0x100a_93e0, 1); popd(esi);                              /* pop esi */
            ii(0x100a_93e1, 1); popd(edx);                              /* pop edx */
            ii(0x100a_93e2, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_93e3, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_93e4, 1); retd();                                 /* ret */
        }
    }
}
