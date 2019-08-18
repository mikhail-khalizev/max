using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_6125-bab0cdaa")]
        public void Method_100a_6125()
        {
            ii(0x100a_6125, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100a_612a, 5); calld(Definitions.sys_check_available_stack_size, 0xb_fc23); /* call 0x10165d52 */
            ii(0x100a_612f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_6130, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_6131, 1); pushd(esi);                             /* push esi */
            ii(0x100a_6132, 1); pushd(edi);                             /* push edi */
            ii(0x100a_6133, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_6134, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6136, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_613c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_613f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_6142, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100a_6149, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100a_6150, 2); jmpd(0x100a_6158, 0x6); goto l_0x100a_6158; /* jmp 0x100a6158 */
        l_0x100a_6152:
            ii(0x100a_6152, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_6155, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100a_6158:
            ii(0x100a_6158, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_615b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_615e, 5); calld(Definitions.my_2_get_count, -0x1_adfb); /* call 0x1008b368 */
            ii(0x100a_6163, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100a_6167, 2); if(jled(0x100a_6189, 0x20)) goto l_0x100a_6189; /* jle 0x100a6189 */
            ii(0x100a_6169, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100a_616d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_6170, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6173, 5); calld(0x1008_b228, -0x1_af50);          /* call 0x1008b228 */
            ii(0x100a_6178, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100a_617b, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100a_617f, 2); if(jnzd(0x100a_6187, 0x6)) goto l_0x100a_6187; /* jnz 0x100a6187 */
            ii(0x100a_6181, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6184, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100a_6187:
            ii(0x100a_6187, 2); jmpd(0x100a_6152, -0x37); goto l_0x100a_6152; /* jmp 0x100a6152 */
        l_0x100a_6189:
            ii(0x100a_6189, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_618c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_618f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_6192, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6194, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_6195, 1); popd(edi);                              /* pop edi */
            ii(0x100a_6196, 1); popd(esi);                              /* pop esi */
            ii(0x100a_6197, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_6198, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_6199, 1); retd(); return;                         /* ret */
        }
    }
}
