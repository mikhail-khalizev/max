using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_61f9-d958969e")]
        public void Method_1013_61f9()
        {
            ii(0x1013_61f9, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_61fe, 5); calld(Definitions.sys_check_available_stack_size, 0x2_fb4f); /* call 0x10165d52 */
            ii(0x1013_6203, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_6204, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_6205, 1); pushd(edx);                             /* push edx */
            ii(0x1013_6206, 1); pushd(esi);                             /* push esi */
            ii(0x1013_6207, 1); pushd(edi);                             /* push edi */
            ii(0x1013_6208, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_6209, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_620b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_6211, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_6214, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_6218, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_621e, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1013_6224, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_6229, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_622b, 2); if(jnzd(0x1013_626e, 0x41)) goto l_0x1013_626e; /* jnz 0x1013626e */
            ii(0x1013_622d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_6231, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_6237, 10); mov(memd_a32[ds, eax + 0x101c_a6a3], 0); /* mov dword [eax+0x101ca6a3], 0x0 */
            ii(0x1013_6241, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_6245, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_624b, 10); mov(memd_a32[ds, eax + 0x101c_a6a7], 0); /* mov dword [eax+0x101ca6a7], 0x0 */
            ii(0x1013_6255, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_6259, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_625f, 10); mov(memd_a32[ds, eax + 0x101c_a6ab], 0); /* mov dword [eax+0x101ca6ab], 0x0 */
            ii(0x1013_6269, 5); jmpd(0x1013_630d, 0x9f); goto l_0x1013_630d; /* jmp 0x1013630d */
        l_0x1013_626e:
            ii(0x1013_626e, 7); mov(memd_a32[ss, ebp - 0x8], 0x3100);   /* mov dword [ebp-0x8], 0x3100 */
            ii(0x1013_6275, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6278, 5); calld(Definitions.sys_new_arr, 0x2_fd93); /* call 0x10166010 */
            ii(0x1013_627d, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_6281, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1013_6287, 6); mov(memd_a32[ds, edx + 0x101c_a6a3], eax); /* mov [edx+0x101ca6a3], eax */
            ii(0x1013_628d, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1013_6290, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_6292, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_6296, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_629c, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a3]); /* mov eax, [eax+0x101ca6a3] */
            ii(0x1013_62a2, 5); calld(Definitions.sys_memset, 0x2_fb39); /* call 0x10165de0 */
            ii(0x1013_62a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_62aa, 5); calld(Definitions.sys_new_arr, 0x2_fd61); /* call 0x10166010 */
            ii(0x1013_62af, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_62b3, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1013_62b9, 6); mov(memd_a32[ds, edx + 0x101c_a6a7], eax); /* mov [edx+0x101ca6a7], eax */
            ii(0x1013_62bf, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1013_62c2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_62c4, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_62c8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_62ce, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a7]); /* mov eax, [eax+0x101ca6a7] */
            ii(0x1013_62d4, 5); calld(Definitions.sys_memset, 0x2_fb07); /* call 0x10165de0 */
            ii(0x1013_62d9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_62dc, 5); calld(Definitions.sys_new_arr, 0x2_fd2f); /* call 0x10166010 */
            ii(0x1013_62e1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_62e3, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_62e7, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_62ed, 6); mov(memd_a32[ds, eax + 0x101c_a6ab], edx); /* mov [eax+0x101ca6ab], edx */
            ii(0x1013_62f3, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1013_62f6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_62f8, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_62fc, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_6302, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6ab]); /* mov eax, [eax+0x101ca6ab] */
            ii(0x1013_6308, 5); calld(Definitions.sys_memset, 0x2_fad3); /* call 0x10165de0 */
        l_0x1013_630d:
            ii(0x1013_630d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_630f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_6310, 1); popd(edi);                              /* pop edi */
            ii(0x1013_6311, 1); popd(esi);                              /* pop esi */
            ii(0x1013_6312, 1); popd(edx);                              /* pop edx */
            ii(0x1013_6313, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_6314, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_6315, 1); retd(); return;                         /* ret */
        }
    }
}
