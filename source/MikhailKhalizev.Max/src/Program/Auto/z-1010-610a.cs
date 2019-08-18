using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("efc7669e-315a-4172-a1fc-a840623d5e98")]
        public void Method_1010_610a()
        {
            ii(0x1010_610a, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1010_610f, 5); calld(Definitions.sys_check_available_stack_size, 0x5_fc3e); /* call 0x10165d52 */
            ii(0x1010_6114, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6115, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6116, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6117, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6118, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_611a, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_6120, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_6123, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1010_6126, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1010_6129, 4); cmp(memb_a32[ss, ebp - 0x4], 0x76);     /* cmp byte [ebp-0x4], 0x76 */
            ii(0x1010_612d, 6); if(jged(0x1010_61aa, 0x77)) goto l_0x1010_61aa; /* jge 0x101061aa */
            ii(0x1010_6133, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_6137, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_613a, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_613d, 6); mov(eax, memd_a32[ds, eax + 0xac]);     /* mov eax, [eax+0xac] */
            ii(0x1010_6143, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_6146, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_614a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_614d, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_6150, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_6152, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_6155, 6); mov(memd_a32[ds, edx + 0xac], eax);     /* mov [edx+0xac], eax */
            ii(0x1010_615b, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_615f, 5); calld(0x1010_60b4, -0xb0);              /* call 0x101060b4 */
            ii(0x1010_6164, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6165, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_6168, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6169, 5); calld(0x1012_36fa, 0x1_d58c);           /* call 0x101236fa */
            ii(0x1010_616e, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_6171, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_6173, 2); if(jzd(0x1010_61a2, 0x2d)) goto l_0x1010_61a2; /* jz 0x101061a2 */
            ii(0x1010_6175, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_6179, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_617c, 6); pushd(memd_a32[ds, eax + 0x101b_8b80]); /* push dword [eax+0x101b8b80] */
            ii(0x1010_6182, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_6185, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6186, 5); calld(0x1012_3850, 0x1_d6c5);           /* call 0x10123850 */
            ii(0x1010_618b, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_618e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_6190, 2); if(jzd(0x1010_61a2, 0x10)) goto l_0x1010_61a2; /* jz 0x101061a2 */
            ii(0x1010_6192, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_6195, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6196, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_6199, 1); pushd(eax);                             /* push eax */
            ii(0x1010_619a, 5); calld(0x1012_3d82, 0x1_dbe3);           /* call 0x10123d82 */
            ii(0x1010_619f, 3); add(esp, 0x8);                          /* add esp, 0x8 */
        l_0x1010_61a2:
            ii(0x1010_61a2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_61a5, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_61a8, 2); jmpd(0x1010_61b1, 0x7); goto l_0x1010_61b1; /* jmp 0x101061b1 */
        l_0x1010_61aa:
            ii(0x1010_61aa, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1010_61b1:
            ii(0x1010_61b1, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_61b4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_61b6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_61b7, 1); popd(edi);                              /* pop edi */
            ii(0x1010_61b8, 1); popd(esi);                              /* pop esi */
            ii(0x1010_61b9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_61ba, 1); retd(); return;                         /* ret */
        }
    }
}
