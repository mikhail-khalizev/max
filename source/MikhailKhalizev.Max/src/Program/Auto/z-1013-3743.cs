using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("17aa1c4e-f5c0-4757-8c43-def742b2749f")]
        public void Method_1013_3743()
        {
            ii(0x1013_3743, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1013_3748, 5); calld(Definitions.sys_check_available_stack_size, 0x32605); /* call 0x10165d52 */
            ii(0x1013_374d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_374e, 1); pushd(esi);                             /* push esi */
            ii(0x1013_374f, 1); pushd(edi);                             /* push edi */
            ii(0x1013_3750, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_3751, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3753, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1013_3759, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_375c, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1013_375f, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1013_3762, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_3766, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_376c, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1013_3771, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_3773, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1013_3777, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1013_377a, 6); add(edx, 0x88);                         /* add edx, 0x88 */
            ii(0x1013_3780, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_3782, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1013_3785, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_3788, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1013_378b, 2); if(jnzd(0x1013_3799, 0xc)) goto l_0x1013_3799; /* jnz 0x10133799 */
            ii(0x1013_378d, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_3794, 5); jmpd(0x1013_38b1, 0x118); goto l_0x1013_38b1; /* jmp 0x101338b1 */
        l_0x1013_3799:
            ii(0x1013_3799, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_379d, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_37a1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_37a7, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1013_37ad, 5); calld(0x100c_b6b0, -0x68102);           /* call 0x100cb6b0 */
            ii(0x1013_37b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_37b4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1013_37b7, 5); calld(0x1007_6800, -0xbcfbc);           /* call 0x10076800 */
            ii(0x1013_37bc, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_37bf, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1013_37c2, 5); jmpd(0x1013_3868, 0xa1); goto l_0x1013_3868; /* jmp 0x10133868 */
        //  ii(0x1013_37c7, 131); Недостижимый код.
l_0x1013_384a:
            ii(0x1013_384a, 2); jmpd(0x1013_3883, 0x37); goto l_0x1013_3883; /* jmp 0x10133883 */
        //  ii(0x1013_384c, 28); Недостижимый код.
l_0x1013_3868:
            ii(0x1013_3868, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1013_386b, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x1013_386e, 4); cmp(memb_a32[ss, ebp - 0x24], 0x6);     /* cmp byte [ebp-0x24], 0x6 */
            ii(0x1013_3872, 2); if(jad(0x1013_384a, -0x2a)) goto l_0x1013_384a; /* ja 0x1013384a */
            ii(0x1013_3874, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_3876, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x1013_3879, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_387c, 7); jmpd_abs(memd_a32[cs, eax + 0x1013_384c]); return; /* jmp dword [cs:eax+0x1013384c] */
        l_0x1013_3883:
            ii(0x1013_3883, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1013_3887, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_388a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_388c, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_388f, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1013_3894, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_3896, 2); div(ebx);                               /* div ebx */
            ii(0x1013_3898, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_389b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_389d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1013_38a0, 5); calld(0x1007_5eec, -0xbd9b9);           /* call 0x10075eec */
            ii(0x1013_38a5, 2); jmpd(0x1013_38b1, 0xa); goto l_0x1013_38b1; /* jmp 0x101338b1 */
        //  ii(0x1013_38a7, 10); Недостижимый код.
l_0x1013_38b1:
            ii(0x1013_38b1, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_38b4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_38b6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_38b7, 1); popd(edi);                              /* pop edi */
            ii(0x1013_38b8, 1); popd(esi);                              /* pop esi */
            ii(0x1013_38b9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_38ba, 1); retd(); return;                         /* ret */
        }
    }
}
