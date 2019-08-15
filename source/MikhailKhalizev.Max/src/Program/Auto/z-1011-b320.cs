using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2ba0a661-e4b4-42db-a4b6-bc636755cbea")]
        public void Method_1011_b320()
        {
            ii(0x1011_b320, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_b325, 5); calld(Definitions.sys_check_available_stack_size, 0x4_aa28); /* call 0x10165d52 */
            ii(0x1011_b32a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_b32b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_b32c, 1); pushd(esi);                             /* push esi */
            ii(0x1011_b32d, 1); pushd(edi);                             /* push edi */
            ii(0x1011_b32e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_b32f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_b331, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_b337, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_b33a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_b33d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_b340, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x1011_b343, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_b346, 5); mov(edx, StringDefinitions.XEnd4);      /* mov edx, 0x101a7d7b */
            ii(0x1011_b34b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b34e, 5); calld(0x1014_74f5, 0x2_c1a2);           /* call 0x101474f5 */
            ii(0x1011_b353, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_b356, 3); mov(ebx, memd_a32[ds, eax + 0x8]);      /* mov ebx, [eax+0x8] */
            ii(0x1011_b359, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_b35c, 5); mov(edx, StringDefinitions.YEnd4);      /* mov edx, 0x101a7d81 */
            ii(0x1011_b361, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b364, 5); calld(0x1014_74f5, 0x2_c18c);           /* call 0x101474f5 */
            ii(0x1011_b369, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_b36c, 3); mov(ebx, memd_a32[ds, eax + 0x14]);     /* mov ebx, [eax+0x14] */
            ii(0x1011_b36f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_b372, 5); mov(edx, StringDefinitions.Index10);    /* mov edx, 0x101a7d87 */
            ii(0x1011_b377, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b37a, 5); calld(0x1014_74f5, 0x2_c176);           /* call 0x101474f5 */
            ii(0x1011_b37f, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_b386, 2); jmpd(0x1011_b38e, 0x6); goto l_0x1011_b38e; /* jmp 0x1011b38e */
        l_0x1011_b388:
            ii(0x1011_b388, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_b38b, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1011_b38e:
            ii(0x1011_b38e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_b391, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b394, 5); calld(0x100b_82bc, -0x6_30dd);          /* call 0x100b82bc */
            ii(0x1011_b399, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1011_b39d, 2); if(jled(0x1011_b3f5, 0x56)) goto l_0x1011_b3f5; /* jle 0x1011b3f5 */
            ii(0x1011_b39f, 5); mov(edx, StringDefinitions.Step2);      /* mov edx, 0x101a7d8d */
            ii(0x1011_b3a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b3a7, 5); calld(0x1014_73de, 0x2_c032);           /* call 0x101473de */
            ii(0x1011_b3ac, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_b3b0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_b3b3, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b3b6, 5); calld(0x100b_827c, -0x6_313f);          /* call 0x100b827c */
            ii(0x1011_b3bb, 3); movsx(ebx, memb_a32[ds, eax]);          /* movsx ebx, byte [eax] */
            ii(0x1011_b3be, 5); mov(edx, StringDefinitions.X6);         /* mov edx, 0x101a7d92 */
            ii(0x1011_b3c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b3c6, 5); calld(0x1014_74f5, 0x2_c12a);           /* call 0x101474f5 */
            ii(0x1011_b3cb, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_b3cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_b3d2, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b3d5, 5); calld(0x100b_827c, -0x6_315e);          /* call 0x100b827c */
            ii(0x1011_b3da, 4); movsx(ebx, memb_a32[ds, eax + 0x1]);    /* movsx ebx, byte [eax+0x1] */
            ii(0x1011_b3de, 5); mov(edx, StringDefinitions.Y4);         /* mov edx, 0x101a7d94 */
            ii(0x1011_b3e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b3e6, 5); calld(0x1014_74f5, 0x2_c10a);           /* call 0x101474f5 */
            ii(0x1011_b3eb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_b3ee, 5); calld(0x1014_7446, 0x2_c053);           /* call 0x10147446 */
            ii(0x1011_b3f3, 2); jmpd(0x1011_b388, -0x6d); goto l_0x1011_b388; /* jmp 0x1011b388 */
        l_0x1011_b3f5:
            ii(0x1011_b3f5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_b3f7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_b3f8, 1); popd(edi);                              /* pop edi */
            ii(0x1011_b3f9, 1); popd(esi);                              /* pop esi */
            ii(0x1011_b3fa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_b3fb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_b3fc, 1); retd(); return;                         /* ret */
        }
    }
}
