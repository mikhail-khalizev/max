using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_cd68-d7387346")]
        public void Method_100c_cd68()
        {
            ii(0x100c_cd68, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_cd6d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_8fe0); /* call 0x10165d52 */
            ii(0x100c_cd72, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_cd73, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_cd74, 1); pushd(edx);                             /* push edx */
            ii(0x100c_cd75, 1); pushd(esi);                             /* push esi */
            ii(0x100c_cd76, 1); pushd(edi);                             /* push edi */
            ii(0x100c_cd77, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_cd78, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_cd7a, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_cd80, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_cd83, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_cd85, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_cd88, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_cd8b, 5); calld(0x1013_ad11, 0x6_df81);           /* call 0x1013ad11 */
            ii(0x100c_cd90, 2); test(al, al);                           /* test al, al */
            ii(0x100c_cd92, 2); if(jnzd(0x100c_cdcd, 0x39)) goto l_0x100c_cdcd; /* jnz 0x100ccdcd */
            ii(0x100c_cd94, 5); calld(0x1008_ac50, -0x4_2149);          /* call 0x1008ac50 */
            ii(0x100c_cd99, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_cd9b, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_cd9d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_cda0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_cda3, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_cda6, 5); calld(0x1007_6574, -0x5_6837);          /* call 0x10076574 */
            ii(0x100c_cdab, 5); calld(0x1015_2962, 0x8_5bb2);           /* call 0x10152962 */
            ii(0x100c_cdb0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_cdb3, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_cdb6, 5); calld(0x1007_65d0, -0x5_67eb);          /* call 0x100765d0 */
            ii(0x100c_cdbb, 5); calld(0x100a_b50c, -0x2_18b4);          /* call 0x100ab50c */
            ii(0x100c_cdc0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_cdc2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_cdc5, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_cdc8, 5); calld(0x1007_6630, -0x5_679d);          /* call 0x10076630 */
        l_0x100c_cdcd:
            ii(0x100c_cdcd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_cdcf, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_cdd0, 1); popd(edi);                              /* pop edi */
            ii(0x100c_cdd1, 1); popd(esi);                              /* pop esi */
            ii(0x100c_cdd2, 1); popd(edx);                              /* pop edx */
            ii(0x100c_cdd3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_cdd4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_cdd5, 1); retd();                                 /* ret */
        }
    }
}
