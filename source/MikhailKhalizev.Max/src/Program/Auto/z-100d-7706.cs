using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6511080c-f1ed-4da4-9891-a6efed2ac105")]
        public void Method_100d_7706()
        {
            ii(0x100d_7706, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100d_770b, 5); calld(Definitions.sys_check_available_stack_size, 0x8_e642); /* call 0x10165d52 */
            ii(0x100d_7710, 1); pushd(esi);                             /* push esi */
            ii(0x100d_7711, 1); pushd(edi);                             /* push edi */
            ii(0x100d_7712, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_7713, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_7715, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100d_771b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_771e, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100d_7721, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100d_7724, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100d_7727, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_7729, 3); mov(al, memb_a32[ss, ebp + 0x24]);      /* mov al, [ebp+0x24] */
            ii(0x100d_772c, 1); pushd(eax);                             /* push eax */
            ii(0x100d_772d, 4); movsx(eax, memw_a32[ss, ebp + 0x20]);   /* movsx eax, word [ebp+0x20] */
            ii(0x100d_7731, 1); pushd(eax);                             /* push eax */
            ii(0x100d_7732, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x100d_7735, 1); pushd(eax);                             /* push eax */
            ii(0x100d_7736, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x100d_7739, 1); pushd(eax);                             /* push eax */
            ii(0x100d_773a, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x100d_773d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_773e, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100d_7742, 1); pushd(eax);                             /* push eax */
            ii(0x100d_7743, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100d_7746, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100d_7749, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100d_774c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_774f, 5); calld(0x100d_6be4, -0xb70);             /* call 0x100d6be4 */
            ii(0x100d_7754, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_7757, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_775a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_775d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_7760, 7); mov(memd_a32[ds, eax + 0x27], 0x101b_5f74); /* mov dword [eax+0x27], 0x101b5f74 */
            ii(0x100d_7767, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_776a, 6); mov(memw_a32[ds, eax + 0x2b], 0);       /* mov word [eax+0x2b], 0x0 */
            ii(0x100d_7770, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_7773, 6); mov(memw_a32[ds, eax + 0x2d], 0x9000);  /* mov word [eax+0x2d], 0x9000 */
            ii(0x100d_7779, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_777c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_777f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_7782, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_7784, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_7785, 1); popd(edi);                              /* pop edi */
            ii(0x100d_7786, 1); popd(esi);                              /* pop esi */
            ii(0x100d_7787, 3); retd(0x18); return;                     /* ret 0x18 */
        }
    }
}
