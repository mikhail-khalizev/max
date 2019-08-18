using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8bf4567a-5965-4e47-8f85-f3a372c41fde")]
        public void Method_100f_ea2b()
        {
            ii(0x100f_ea2b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_ea30, 5); calld(Definitions.sys_check_available_stack_size, 0x6_731d); /* call 0x10165d52 */
            ii(0x100f_ea35, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_ea36, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_ea37, 1); pushd(edx);                             /* push edx */
            ii(0x100f_ea38, 1); pushd(esi);                             /* push esi */
            ii(0x100f_ea39, 1); pushd(edi);                             /* push edi */
            ii(0x100f_ea3a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_ea3b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_ea3d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100f_ea43, 7); mov(memd_a32[ss, ebp - 0x4], 0x4);      /* mov dword [ebp-0x4], 0x4 */
        l_0x100f_ea4a:
            ii(0x100f_ea4a, 3); dec(memd_a32[ss, ebp - 0x4]);           /* dec dword [ebp-0x4] */
            ii(0x100f_ea4d, 5); cmp(memw_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x100f_ea52, 2); if(jzd(0x100f_eaad, 0x59)) goto l_0x100f_eaad; /* jz 0x100feaad */
            ii(0x100f_ea54, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ea58, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_ea5e, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_ea64, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_ea69, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_ea6b, 2); if(jzd(0x100f_ea87, 0x1a)) goto l_0x100f_ea87; /* jz 0x100fea87 */
            ii(0x100f_ea6d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ea71, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_ea77, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_ea7d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_ea82, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_ea85, 2); if(jnzd(0x100f_ea89, 0x2)) goto l_0x100f_ea89; /* jnz 0x100fea89 */
        l_0x100f_ea87:
            ii(0x100f_ea87, 2); jmpd(0x100f_eaab, 0x22); goto l_0x100f_eaab; /* jmp 0x100feaab */
        l_0x100f_ea89:
            ii(0x100f_ea89, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ea8d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_ea93, 6); mov(al, memb_a32[ds, eax + 0x101c_a491]); /* mov al, [eax+0x101ca491] */
            ii(0x100f_ea99, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_ea9e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_eaa0, 2); if(jnzd(0x100f_eaab, 0x9)) goto l_0x100f_eaab; /* jnz 0x100feaab */
            ii(0x100f_eaa2, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_eaa9, 2); jmpd(0x100f_eab4, 0x9); goto l_0x100f_eab4; /* jmp 0x100feab4 */
        l_0x100f_eaab:
            ii(0x100f_eaab, 2); jmpd(0x100f_ea4a, -0x63); goto l_0x100f_ea4a; /* jmp 0x100fea4a */
        l_0x100f_eaad:
            ii(0x100f_eaad, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
        l_0x100f_eab4:
            ii(0x100f_eab4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_eab7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_eab9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_eaba, 1); popd(edi);                              /* pop edi */
            ii(0x100f_eabb, 1); popd(esi);                              /* pop esi */
            ii(0x100f_eabc, 1); popd(edx);                              /* pop edx */
            ii(0x100f_eabd, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_eabe, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_eabf, 1); retd(); return;                         /* ret */
        }
    }
}
