using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4591048c-76c6-420c-b51c-8b33cbc9c396")]
        public void Method_100a_2d9b()
        {
            ii(0x100a_2d9b, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_2da0, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2fad); /* call 0x10165d52 */
            ii(0x100a_2da5, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2da6, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2da7, 1); pushd(edx);                             /* push edx */
            ii(0x100a_2da8, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2da9, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2daa, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2dab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2dad, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_2db3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_2db6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_2db8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2dbb, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_2dbe, 5); calld(0x1013_ad71, 0x9_7fae);           /* call 0x1013ad71 */
            ii(0x100a_2dc3, 2); test(al, al);                           /* test al, al */
            ii(0x100a_2dc5, 2); if(jzd(0x100a_2de6, 0x1f)) goto l_0x100a_2de6; /* jz 0x100a2de6 */
            ii(0x100a_2dc7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2dca, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_2dcd, 5); calld(0x1008_af28, -0x1_7eaa);          /* call 0x1008af28 */
            ii(0x100a_2dd2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_2dd5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_2dd8, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_2ddb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_2dde, 3); calld_abs(memd_a32[ds, edx + 0x24]);    /* call dword [edx+0x24] */
            ii(0x100a_2de1, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100a_2de4, 2); jmpd(0x100a_2dea, 0x4); goto l_0x100a_2dea; /* jmp 0x100a2dea */
        l_0x100a_2de6:
            ii(0x100a_2de6, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100a_2dea:
            ii(0x100a_2dea, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_2ded, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2def, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2df0, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2df1, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2df2, 1); popd(edx);                              /* pop edx */
            ii(0x100a_2df3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2df4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2df5, 1); retd(); return;                         /* ret */
        }
    }
}
