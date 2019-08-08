using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("abf5ff88-c340-438f-a3f9-fef1fc3b809d")]
        public void Method_1010_3985()
        {
            ii(0x1010_3985, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1010_398a, 5); calld(Definitions.sys_check_available_stack_size, 0x6_23c3); /* call 0x10165d52 */
            ii(0x1010_398f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_3990, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_3991, 1); pushd(esi);                             /* push esi */
            ii(0x1010_3992, 1); pushd(edi);                             /* push edi */
            ii(0x1010_3993, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_3994, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3996, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1010_399c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_399f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_39a2, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1010_39a6, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_39a9, 5); calld(0x1010_45d4, 0xc26);              /* call 0x101045d4 */
            ii(0x1010_39ae, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_39b1, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1010_39b5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_39b8, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1010_39bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_39be, 5); calld(0x1013_c0fa, 0x3_8737);           /* call 0x1013c0fa */
            ii(0x1010_39c3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_39c6, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_39c8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_39cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_39ce, 5); calld(0x1013_c0fa, 0x3_8727);           /* call 0x1013c0fa */
            ii(0x1010_39d3, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_39da, 2); jmpd(0x1010_39e2, 0x6); goto l_0x1010_39e2; /* jmp 0x101039e2 */
        l_0x1010_39dc:
            ii(0x1010_39dc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_39df, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1010_39e2:
            ii(0x1010_39e2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_39e5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_39e8, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x1010_39eb, 2); if(jged(0x1010_3a56, 0x69)) goto l_0x1010_3a56; /* jge 0x10103a56 */
            ii(0x1010_39ed, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_39f1, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1010_39f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_39f7, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1010_39fa, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_39fc, 5); calld(0x1007_6b90, -0x8_ce71);          /* call 0x10076b90 */
            ii(0x1010_3a01, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1010_3a04, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3a07, 5); calld(0x1013_c0fa, 0x3_86ee);           /* call 0x1013c0fa */
            ii(0x1010_3a0c, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_3a10, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1010_3a13, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3a16, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1010_3a19, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_3a1b, 5); calld(0x1010_46a4, 0xc84);              /* call 0x101046a4 */
            ii(0x1010_3a20, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3a22, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_3a25, 5); calld(0x1010_4514, 0xaea);              /* call 0x10104514 */
            ii(0x1010_3a2a, 2); jmpd(0x1010_3a34, 0x8); goto l_0x1010_3a34; /* jmp 0x10103a34 */
        l_0x1010_3a2c:
            ii(0x1010_3a2c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_3a2f, 5); calld(0x1007_6bf8, -0x8_ce3c);          /* call 0x10076bf8 */
        l_0x1010_3a34:
            ii(0x1010_3a34, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3a36, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_3a39, 5); calld(0x1013_ad71, 0x3_7333);           /* call 0x1013ad71 */
            ii(0x1010_3a3e, 2); test(al, al);                           /* test al, al */
            ii(0x1010_3a40, 2); if(jzd(0x1010_3a54, 0x12)) goto l_0x1010_3a54; /* jz 0x10103a54 */
            ii(0x1010_3a42, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_3a45, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_3a48, 5); calld(0x1010_44b0, 0xa63);              /* call 0x101044b0 */
            ii(0x1010_3a4d, 5); calld(0x1010_312d, -0x925);             /* call 0x1010312d */
            ii(0x1010_3a52, 2); jmpd(0x1010_3a2c, -0x28); goto l_0x1010_3a2c; /* jmp 0x10103a2c */
        l_0x1010_3a54:
            ii(0x1010_3a54, 2); jmpd(0x1010_39dc, -0x7a); goto l_0x1010_39dc; /* jmp 0x101039dc */
        l_0x1010_3a56:
            ii(0x1010_3a56, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3a58, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_3a5b, 5); calld(0x1010_4470, 0xa10);              /* call 0x10104470 */
            ii(0x1010_3a60, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3a62, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_3a63, 1); popd(edi);                              /* pop edi */
            ii(0x1010_3a64, 1); popd(esi);                              /* pop esi */
            ii(0x1010_3a65, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_3a66, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_3a67, 1); retd(); return;                         /* ret */
        }
    }
}
