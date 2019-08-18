using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1fcd-2684c2a4")]
        public void my_string_toupper()
        {
            ii(0x1014_1fcd, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_1fd2, 5); calld(Definitions.sys_check_available_stack_size, 0x2_3d7b); /* call 0x10165d52 */
            ii(0x1014_1fd7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_1fd8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_1fd9, 1); pushd(edx);                             /* push edx */
            ii(0x1014_1fda, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1fdb, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1fdc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_1fdd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1fdf, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_1fe5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_1fe8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1feb, 5); calld(Definitions.my_string_make_single_ref, 0x36c); /* call 0x1014235c */
            ii(0x1014_1ff0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1ff3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1ff5, 5); calld(Definitions.my_strobj_c_str, -0xb_87fe); /* call 0x100897fc */
            ii(0x1014_1ffa, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_1ffd, 2); jmpd(0x1014_2005, 0x6); goto l_0x1014_2005; /* jmp 0x10142005 */
        l_0x1014_1fff:
            ii(0x1014_1fff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_2002, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1014_2005:
            ii(0x1014_2005, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_2008, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x1014_200b, 2); if(jzd(0x1014_2025, 0x18)) goto l_0x1014_2025; /* jz 0x10142025 */
            ii(0x1014_200d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_2010, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1014_2012, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_2017, 5); calld(Definitions.sys_toupper, 0x3_eece); /* call 0x10180eea */
            ii(0x1014_201c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_201e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_2021, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x1014_2023, 2); jmpd(0x1014_1fff, -0x26); goto l_0x1014_1fff; /* jmp 0x10141fff */
        l_0x1014_2025:
            ii(0x1014_2025, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_2028, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_202b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_202e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_2030, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_2031, 1); popd(edi);                              /* pop edi */
            ii(0x1014_2032, 1); popd(esi);                              /* pop esi */
            ii(0x1014_2033, 1); popd(edx);                              /* pop edx */
            ii(0x1014_2034, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_2035, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_2036, 1); retd(); return;                         /* ret */
        }
    }
}
