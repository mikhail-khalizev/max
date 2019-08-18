using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_88d6-9dfd0541")]
        public void Method_1009_88d6()
        {
            ii(0x1009_88d6, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1009_88db, 5); calld(Definitions.sys_check_available_stack_size, 0xc_d472); /* call 0x10165d52 */
            ii(0x1009_88e0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_88e1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_88e2, 1); pushd(esi);                             /* push esi */
            ii(0x1009_88e3, 1); pushd(edi);                             /* push edi */
            ii(0x1009_88e4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_88e5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_88e7, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_88ed, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_88f0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_88f3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_88f6, 3); mov(eax, memd_a32[ds, eax + 0x11]);     /* mov eax, [eax+0x11] */
            ii(0x1009_88f9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_88fc, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_88ff, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x1009_8905, 5); mov(eax, StringDefinitions.CreateAS);   /* mov eax, 0x101a0627 */
            ii(0x1009_890a, 1); pushd(eax);                             /* push eax */
            ii(0x1009_890b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_890e, 1); pushd(eax);                             /* push eax */
            ii(0x1009_890f, 5); calld(Definitions.sys_sprintf, 0xc_d5ed); /* call 0x10165f01 */
            ii(0x1009_8914, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1009_8917, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_8919, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_891c, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_891f, 5); calld(0x1013_ad71, 0xa_244d);           /* call 0x1013ad71 */
            ii(0x1009_8924, 2); test(al, al);                           /* test al, al */
            ii(0x1009_8926, 2); if(jzd(0x1009_893e, 0x16)) goto l_0x1009_893e; /* jz 0x1009893e */
            ii(0x1009_8928, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_892b, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_892e, 5); calld(0x1007_6574, -0x2_23bf);          /* call 0x10076574 */
            ii(0x1009_8933, 5); calld(0x1009_c9a0, 0x4068);             /* call 0x1009c9a0 */
            ii(0x1009_8938, 1); cwde();                                 /* cwde */
            ii(0x1009_8939, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1009_893c, 2); if(jgd(0x1009_8940, 0x2)) goto l_0x1009_8940; /* jg 0x10098940 */
        l_0x1009_893e:
            ii(0x1009_893e, 2); jmpd(0x1009_894d, 0xd); goto l_0x1009_894d; /* jmp 0x1009894d */
        l_0x1009_8940:
            ii(0x1009_8940, 5); mov(edx, StringDefinitions.AtX2Rate2);  /* mov edx, 0x101a0633 */
            ii(0x1009_8945, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8948, 5); calld(Definitions.sys_strcat, 0xc_d5e4); /* call 0x10165f31 */
        l_0x1009_894d:
            ii(0x1009_894d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8950, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_8953, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_8956, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_8958, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_8959, 1); popd(edi);                              /* pop edi */
            ii(0x1009_895a, 1); popd(esi);                              /* pop esi */
            ii(0x1009_895b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_895c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_895d, 1); retd(); return;                         /* ret */
        }
    }
}
