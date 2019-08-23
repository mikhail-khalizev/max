using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_1d25-d1d0f289")]
        public void Method_1015_1d25()
        {
            ii(0x1015_1d25, 5); pushd(0x108);                           /* push 0x108 */
            ii(0x1015_1d2a, 5); calld(Definitions.sys_check_available_stack_size, 0x1_4023); /* call 0x10165d52 */
            ii(0x1015_1d2f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_1d30, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_1d31, 1); pushd(esi);                             /* push esi */
            ii(0x1015_1d32, 1); pushd(edi);                             /* push edi */
            ii(0x1015_1d33, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_1d34, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_1d36, 6); sub(esp, 0xe0);                         /* sub esp, 0xe0 */
            ii(0x1015_1d3c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_1d3f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_1d42, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_1d45, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_1d48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1d4b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1d4d, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_1d50, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_1d53, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1015_1d56, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_1d58, 2); if(jzd(0x1015_1da9, 0x4f)) goto l_0x1015_1da9; /* jz 0x10151da9 */
            ii(0x1015_1d5a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_1d5d, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1015_1d60, 1); pushd(eax);                             /* push eax */
            ii(0x1015_1d61, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1d64, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_1d67, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_1d6c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_1d6d, 5); mov(eax, StringDefinitions.BuildPacketExpectedTeamIReceivedTeamI); /* mov eax, 0x101ade93 */
            ii(0x1015_1d72, 1); pushd(eax);                             /* push eax */
            ii(0x1015_1d73, 6); lea(eax, ebp - 0xe0);                   /* lea eax, [ebp-0xe0] */
            ii(0x1015_1d79, 1); pushd(eax);                             /* push eax */
            ii(0x1015_1d7a, 5); calld(Definitions.sys_sprintf, 0x1_4182); /* call 0x10165f01 */
            ii(0x1015_1d7f, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1015_1d82, 5); calld(0x100c_aa00, -0x8_7387);          /* call 0x100caa00 */
            ii(0x1015_1d87, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_1d8c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_1d8d, 5); calld(0x100c_aa20, -0x8_7372);          /* call 0x100caa20 */
            ii(0x1015_1d92, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_1d94, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1015_1d99, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1015_1d9e, 6); lea(eax, ebp - 0xe0);                   /* lea eax, [ebp-0xe0] */
            ii(0x1015_1da4, 5); calld(0x1011_5d23, -0x3_c086);          /* call 0x10115d23 */
        l_0x1015_1da9:
            ii(0x1015_1da9, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_1dac, 3); mov(dl, memb_a32[ds, eax + 0x2]);       /* mov dl, [eax+0x2] */
            ii(0x1015_1daf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1db2, 3); mov(memb_a32[ds, eax + 0x3e], dl);      /* mov [eax+0x3e], dl */
            ii(0x1015_1db5, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_1db8, 3); mov(dl, memb_a32[ds, eax + 0x4]);       /* mov dl, [eax+0x4] */
            ii(0x1015_1dbb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1dbe, 3); mov(memb_a32[ds, eax + 0x45], dl);      /* mov [eax+0x45], dl */
            ii(0x1015_1dc1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_1dc4, 4); mov(dx, memw_a32[ds, eax + 0x6]);       /* mov dx, [eax+0x6] */
            ii(0x1015_1dc8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1dcb, 4); mov(memw_a32[ds, eax + 0x78], dx);      /* mov [eax+0x78], dx */
            ii(0x1015_1dcf, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_1dd2, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1015_1dd6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1dd9, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1015_1ddd, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_1de0, 4); mov(dx, memw_a32[ds, eax + 0xa]);       /* mov dx, [eax+0xa] */
            ii(0x1015_1de4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1de7, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1015_1deb, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_1dee, 3); mov(dl, memb_a32[ds, eax + 0x3]);       /* mov dl, [eax+0x3] */
            ii(0x1015_1df1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1df4, 3); mov(memb_a32[ds, eax + 0x7a], dl);      /* mov [eax+0x7a], dl */
            ii(0x1015_1df7, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_1dfa, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1015_1dfe, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_1e01, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_1e04, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1015_1e07, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_1e0a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1e0d, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_1e10, 5); calld(0x1009_caf8, -0xb_531d);          /* call 0x1009caf8 */
            ii(0x1015_1e15, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1015_1e1c, 2); jmpd(0x1015_1e24, 0x6); goto l_0x1015_1e24; /* jmp 0x10151e24 */
        l_0x1015_1e1e:
            ii(0x1015_1e1e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_1e21, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1015_1e24:
            ii(0x1015_1e24, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_1e27, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1015_1e2b, 2); if(jged(0x1015_1e45, 0x18)) goto l_0x1015_1e45; /* jge 0x10151e45 */
            ii(0x1015_1e2d, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_1e31, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1015_1e33, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1015_1e36, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_1e38, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1e3b, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_1e3e, 5); calld(0x1008_b2a8, -0xc_6b9b);          /* call 0x1008b2a8 */
            ii(0x1015_1e43, 2); jmpd(0x1015_1e1e, -0x27); goto l_0x1015_1e1e; /* jmp 0x10151e1e */
        l_0x1015_1e45:
            ii(0x1015_1e45, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1e48, 5); calld(0x1015_1565, -0x8e8);             /* call 0x10151565 */
            ii(0x1015_1e4d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_1e4f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_1e50, 1); popd(edi);                              /* pop edi */
            ii(0x1015_1e51, 1); popd(esi);                              /* pop esi */
            ii(0x1015_1e52, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_1e53, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_1e54, 1); retd();                                 /* ret */
        }
    }
}
