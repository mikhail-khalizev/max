using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b609de51-a014-4d1f-91ef-af5cc20fb4fd")]
        public void Method_1007_ab23()
        {
            ii(0x1007_ab23, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_ab28, 5); calld(Definitions.sys_check_available_stack_size, 0xe_b225); /* call 0x10165d52 */
            ii(0x1007_ab2d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_ab2e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_ab2f, 1); pushd(esi);                             /* push esi */
            ii(0x1007_ab30, 1); pushd(edi);                             /* push edi */
            ii(0x1007_ab31, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_ab32, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_ab34, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_ab3a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_ab3d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_ab40, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ab43, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1007_ab46, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_ab4b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_ab4d, 2); if(jzd(0x1007_ab5e, 0xf)) goto l_0x1007_ab5e; /* jz 0x1007ab5e */
            ii(0x1007_ab4f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_ab52, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ab55, 5); calld(0x1015_2a52, 0xd_7ef8);           /* call 0x10152a52 */
            ii(0x1007_ab5a, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ab5c, 2); if(jnzd(0x1007_ab64, 0x6)) goto l_0x1007_ab64; /* jnz 0x1007ab64 */
        l_0x1007_ab5e:
            ii(0x1007_ab5e, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_ab62, 2); jmpd(0x1007_ab8c, 0x28); goto l_0x1007_ab8c; /* jmp 0x1007ab8c */
        l_0x1007_ab64:
            ii(0x1007_ab64, 5); mov(ebx, 0x1007_a353);                  /* mov ebx, 0x1007a353 */
            ii(0x1007_ab69, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_ab6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ab6f, 5); calld(0x1007_8d4a, -0x1e2a);            /* call 0x10078d4a */
            ii(0x1007_ab74, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ab76, 2); if(jzd(0x1007_ab7e, 0x6)) goto l_0x1007_ab7e; /* jz 0x1007ab7e */
            ii(0x1007_ab78, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_ab7c, 2); jmpd(0x1007_ab8c, 0xe); goto l_0x1007_ab8c; /* jmp 0x1007ab8c */
        l_0x1007_ab7e:
            ii(0x1007_ab7e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_ab81, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_ab84, 5); calld(0x1007_aa70, -0x119);             /* call 0x1007aa70 */
            ii(0x1007_ab89, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x1007_ab8c:
            ii(0x1007_ab8c, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1007_ab8f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_ab91, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_ab92, 1); popd(edi);                              /* pop edi */
            ii(0x1007_ab93, 1); popd(esi);                              /* pop esi */
            ii(0x1007_ab94, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_ab95, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_ab96, 1); retd(); return;                         /* ret */
        }
    }
}
