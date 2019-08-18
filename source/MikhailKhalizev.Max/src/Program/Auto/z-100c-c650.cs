using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5283ac16-24e8-41bc-9a35-5bd9110c56bf")]
        public void Method_100c_c650()
        {
            ii(0x100c_c650, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_c655, 5); calld(Definitions.sys_check_available_stack_size, 0x9_96f8); /* call 0x10165d52 */
            ii(0x100c_c65a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_c65b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_c65c, 1); pushd(esi);                             /* push esi */
            ii(0x100c_c65d, 1); pushd(edi);                             /* push edi */
            ii(0x100c_c65e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_c65f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_c661, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_c667, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_c66a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_c66d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_c670, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100c_c673, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c676, 5); calld(0x1007_6d98, -0x5_58e3);          /* call 0x10076d98 */
            ii(0x100c_c67b, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c67d, 2); if(jzd(0x100c_c6b8, 0x39)) goto l_0x100c_c6b8; /* jz 0x100cc6b8 */
            ii(0x100c_c67f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_c682, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100c_c685, 5); calld(0x1008_b060, -0x4_162a);          /* call 0x1008b060 */
            ii(0x100c_c68a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_c68d, 5); calld(0x100c_cd68, 0x6d6);              /* call 0x100ccd68 */
            ii(0x100c_c692, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c694, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_c697, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c69a, 5); calld(0x1007_6630, -0x5_606f);          /* call 0x10076630 */
            ii(0x100c_c69f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_c6a2, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_c6a7, 5); calld(0x100a_5e27, -0x2_6885);          /* call 0x100a5e27 */
            ii(0x100c_c6ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c6ae, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100c_c6b1, 5); calld(0x1008_8b7c, -0x4_3b3a);          /* call 0x10088b7c */
            ii(0x100c_c6b6, 2); jmpd(0x100c_c6d7, 0x1f); goto l_0x100c_c6d7; /* jmp 0x100cc6d7 */
        l_0x100c_c6b8:
            ii(0x100c_c6b8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_c6bb, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100c_c6be, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c6c1, 5); calld(0x1007_6d98, -0x5_592e);          /* call 0x10076d98 */
            ii(0x100c_c6c6, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c6c8, 2); if(jzd(0x100c_c6d7, 0xd)) goto l_0x100c_c6d7; /* jz 0x100cc6d7 */
            ii(0x100c_c6ca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c6cc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_c6cf, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c6d2, 5); calld(0x1007_6630, -0x5_60a7);          /* call 0x10076630 */
        l_0x100c_c6d7:
            ii(0x100c_c6d7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_c6d9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_c6da, 1); popd(edi);                              /* pop edi */
            ii(0x100c_c6db, 1); popd(esi);                              /* pop esi */
            ii(0x100c_c6dc, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_c6dd, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_c6de, 1); retd(); return;                         /* ret */
        }
    }
}
