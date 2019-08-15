using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1e78e932-f361-44f9-b26b-a27dc3051bf9")]
        public void Method_100e_cbb3()
        {
            ii(0x100e_cbb3, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100e_cbb8, 5); calld(Definitions.sys_check_available_stack_size, 0x7_9195); /* call 0x10165d52 */
            ii(0x100e_cbbd, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_cbbe, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_cbbf, 1); pushd(esi);                             /* push esi */
            ii(0x100e_cbc0, 1); pushd(edi);                             /* push edi */
            ii(0x100e_cbc1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_cbc2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_cbc4, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_cbca, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_cbcd, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_cbd0, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_cbd4, 5); calld(0x100e_c3fc, -0x7dd);             /* call 0x100ec3fc */
            ii(0x100e_cbd9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_cbdb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_cbde, 5); calld(0x1007_64b8, -0x7_672b);          /* call 0x100764b8 */
            ii(0x100e_cbe3, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_cbea, 2); jmpd(0x100e_cbf4, 0x8); goto l_0x100e_cbf4; /* jmp 0x100ecbf4 */
        l_0x100e_cbec:
            ii(0x100e_cbec, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_cbef, 5); calld(0x1007_6bf8, -0x7_5ffc);          /* call 0x10076bf8 */
        l_0x100e_cbf4:
            ii(0x100e_cbf4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_cbf6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_cbf9, 5); calld(0x1013_ad71, 0x4_e173);           /* call 0x1013ad71 */
            ii(0x100e_cbfe, 2); test(al, al);                           /* test al, al */
            ii(0x100e_cc00, 2); if(jzd(0x100e_cc59, 0x57)) goto l_0x100e_cc59; /* jz 0x100ecc59 */
            ii(0x100e_cc02, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_cc05, 5); calld(0x1007_63a0, -0x7_686a);          /* call 0x100763a0 */
            ii(0x100e_cc0a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_cc0c, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_cc0f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cc13, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_cc15, 2); if(jnzd(0x100e_cc29, 0x12)) goto l_0x100e_cc29; /* jnz 0x100ecc29 */
            ii(0x100e_cc17, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_cc1a, 5); calld(0x1007_63a0, -0x7_687f);          /* call 0x100763a0 */
            ii(0x100e_cc1f, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100e_cc23, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100e_cc27, 2); if(jzd(0x100e_cc2b, 0x2)) goto l_0x100e_cc2b; /* jz 0x100ecc2b */
        l_0x100e_cc29:
            ii(0x100e_cc29, 2); jmpd(0x100e_cc4f, 0x24); goto l_0x100e_cc4f; /* jmp 0x100ecc4f */
        l_0x100e_cc2b:
            ii(0x100e_cc2b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_cc2e, 5); calld(0x1007_63a0, -0x7_6893);          /* call 0x100763a0 */
            ii(0x100e_cc33, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_cc35, 3); mov(dl, memb_a32[ds, eax + 0x4d]);      /* mov dl, [eax+0x4d] */
            ii(0x100e_cc38, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_cc3b, 5); calld(0x1007_63a0, -0x7_68a0);          /* call 0x100763a0 */
            ii(0x100e_cc40, 5); calld(0x1007_623c, -0x7_6a09);          /* call 0x1007623c */
            ii(0x100e_cc45, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_cc48, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_cc4b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_cc4d, 2); if(jnzd(0x100e_cc51, 0x2)) goto l_0x100e_cc51; /* jnz 0x100ecc51 */
        l_0x100e_cc4f:
            ii(0x100e_cc4f, 2); jmpd(0x100e_cc57, 0x6); goto l_0x100e_cc57; /* jmp 0x100ecc57 */
        l_0x100e_cc51:
            ii(0x100e_cc51, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_cc54, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100e_cc57:
            ii(0x100e_cc57, 2); jmpd(0x100e_cbec, -0x6d); goto l_0x100e_cbec; /* jmp 0x100ecbec */
        l_0x100e_cc59:
            ii(0x100e_cc59, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_cc5c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_cc5f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_cc61, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_cc64, 5); calld(0x1007_5f6c, -0x7_6cfd);          /* call 0x10075f6c */
            ii(0x100e_cc69, 2); jmpd(0x100e_cc75, 0xa); goto l_0x100e_cc75; /* jmp 0x100ecc75 */
        //    ii(0x100e_cc6b, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100e_cc6d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x100e_cc70, 5); calld(0x1007_5f6c, -0x7_6d09);          /* call 0x10075f6c */
        l_0x100e_cc75:
            ii(0x100e_cc75, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_cc78, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_cc7a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_cc7b, 1); popd(edi);                              /* pop edi */
            ii(0x100e_cc7c, 1); popd(esi);                              /* pop esi */
            ii(0x100e_cc7d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_cc7e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_cc7f, 1); retd(); return;                         /* ret */
        }
    }
}
