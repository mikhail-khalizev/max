using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_5d67-5f2d72af")]
        public void Method_100e_5d67()
        {
            ii(0x100e_5d67, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_5d6c, 5); calld(Definitions.sys_check_available_stack_size, 0x7_ffe1); /* call 0x10165d52 */
            ii(0x100e_5d71, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_5d72, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_5d73, 1); pushd(esi);                             /* push esi */
            ii(0x100e_5d74, 1); pushd(edi);                             /* push edi */
            ii(0x100e_5d75, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_5d76, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_5d78, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_5d7e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_5d81, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_5d84, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_5d87, 5); calld(0x1007_6338, -0x6_fa54);          /* call 0x10076338 */
            ii(0x100e_5d8c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_5d8e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_5d91, 5); calld(0x1007_64b8, -0x6_f8de);          /* call 0x100764b8 */
            ii(0x100e_5d96, 2); jmpd(0x100e_5da0, 0x8); goto l_0x100e_5da0; /* jmp 0x100e5da0 */
        l_0x100e_5d98:
            ii(0x100e_5d98, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_5d9b, 5); calld(0x1007_6bf8, -0x6_f1a8);          /* call 0x10076bf8 */
        l_0x100e_5da0:
            ii(0x100e_5da0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_5da2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_5da5, 5); calld(0x1013_ad71, 0x5_4fc7);           /* call 0x1013ad71 */
            ii(0x100e_5daa, 2); test(al, al);                           /* test al, al */
            ii(0x100e_5dac, 2); if(jzd(0x100e_5ddf, 0x31)) goto l_0x100e_5ddf; /* jz 0x100e5ddf */
            ii(0x100e_5dae, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_5db1, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_5db4, 5); calld(0x1007_63d4, -0x6_f9e5);          /* call 0x100763d4 */
            ii(0x100e_5db9, 5); calld(0x100e_5408, -0x9b6);             /* call 0x100e5408 */
            ii(0x100e_5dbe, 2); test(al, al);                           /* test al, al */
            ii(0x100e_5dc0, 2); if(jzd(0x100e_5ddd, 0x1b)) goto l_0x100e_5ddd; /* jz 0x100e5ddd */
            ii(0x100e_5dc2, 5); calld(0x100e_85dc, 0x2815);             /* call 0x100e85dc */
            ii(0x100e_5dc7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_5dc9, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_5dcb, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_5dce, 5); calld(0x1007_63d4, -0x6_f9ff);          /* call 0x100763d4 */
            ii(0x100e_5dd3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_5dd5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_5dd8, 5); calld(0x100e_71bd, 0x13e0);             /* call 0x100e71bd */
        l_0x100e_5ddd:
            ii(0x100e_5ddd, 2); jmpd(0x100e_5d98, -0x47); goto l_0x100e_5d98; /* jmp 0x100e5d98 */
        l_0x100e_5ddf:
            ii(0x100e_5ddf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_5de1, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_5de4, 5); calld(0x1007_5f6c, -0x6_fe7d);          /* call 0x10075f6c */
            ii(0x100e_5de9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_5deb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_5dec, 1); popd(edi);                              /* pop edi */
            ii(0x100e_5ded, 1); popd(esi);                              /* pop esi */
            ii(0x100e_5dee, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_5def, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_5df0, 1); retd(); return;                         /* ret */
        }
    }
}
