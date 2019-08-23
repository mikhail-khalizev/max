using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_1fd4-4ea3a823")]
        public void Method_100c_1fd4()
        {
            ii(0x100c_1fd4, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100c_1fd9, 5); calld(Definitions.sys_check_available_stack_size, 0xa_3d74); /* call 0x10165d52 */
            ii(0x100c_1fde, 1); pushd(esi);                             /* push esi */
            ii(0x100c_1fdf, 1); pushd(edi);                             /* push edi */
            ii(0x100c_1fe0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_1fe1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_1fe3, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100c_1fe9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_1fec, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100c_1fef, 3); mov(memb_a32[ss, ebp - 0x8], bl);       /* mov [ebp-0x8], bl */
            ii(0x100c_1ff2, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x100c_1ff5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_1ff8, 5); calld(0x100b_906f, -0x8f8e);            /* call 0x100b906f */
            ii(0x100c_1ffd, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100c_2000, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100c_2002, 3); mov(cl, memb_a32[ss, ebp - 0x4]);       /* mov cl, [ebp-0x4] */
            ii(0x100c_2005, 4); movsx(ebx, memb_a32[ss, ebp - 0x8]);    /* movsx ebx, byte [ebp-0x8] */
            ii(0x100c_2009, 4); movsx(edx, memb_a32[ss, ebp - 0x14]);   /* movsx edx, byte [ebp-0x14] */
            ii(0x100c_200d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_2010, 5); calld(0x100c_12cd, -0xd48);             /* call 0x100c12cd */
            ii(0x100c_2015, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_2018, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_201c, 2); if(jnzd(0x100c_2027, 0x9)) goto l_0x100c_2027; /* jnz 0x100c2027 */
            ii(0x100c_201e, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100c_2025, 2); jmpd(0x100c_2046, 0x1f); goto l_0x100c_2046; /* jmp 0x100c2046 */
        l_0x100c_2027:
            ii(0x100c_2027, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_202a, 5); calld(0x1007_623c, -0x4_bdf3);          /* call 0x1007623c */
            ii(0x100c_202f, 3); mov(edx, memd_a32[ds, eax + 0xa]);      /* mov edx, [eax+0xa] */
            ii(0x100c_2032, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_2035, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_2038, 5); calld(0x100b_93e1, -0x8c5c);            /* call 0x100b93e1 */
            ii(0x100c_203d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_2040, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x100c_2043, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100c_2046:
            ii(0x100c_2046, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_2049, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_204b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_204c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_204d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_204e, 1); retd();                                 /* ret */
        }
    }
}
