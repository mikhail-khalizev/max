using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3ed1e5f8-b4ab-4f6c-a351-e3518f112dc5")]
        public void Method_1008_664d()
        {
            ii(0x1008_664d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_6652, 5); calld(Definitions.sys_check_available_stack_size, 0xd_f6fb); /* call 0x10165d52 */
            ii(0x1008_6657, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_6658, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_6659, 1); pushd(edx);                             /* push edx */
            ii(0x1008_665a, 1); pushd(esi);                             /* push esi */
            ii(0x1008_665b, 1); pushd(edi);                             /* push edi */
            ii(0x1008_665c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_665d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_665f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_6665, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_6668, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_666b, 5); calld(0x1008_4dd5, -0x189b);            /* call 0x10084dd5 */
            ii(0x1008_6670, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_6672, 2); if(jnzd(0x1008_667a, 0x6)) goto l_0x1008_667a; /* jnz 0x1008667a */
            ii(0x1008_6674, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_6678, 2); jmpd(0x1008_669c, 0x22); goto l_0x1008_669c; /* jmp 0x1008669c */
        l_0x1008_667a:
            ii(0x1008_667a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_667d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_6680, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_6683, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_6686, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_6689, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_668c, 5); calld(0x1007_65d0, -0x1_00c1);          /* call 0x100765d0 */
            ii(0x1008_6691, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6693, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_6696, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
            ii(0x1008_6699, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x1008_669c:
            ii(0x1008_669c, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_669f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_66a1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_66a2, 1); popd(edi);                              /* pop edi */
            ii(0x1008_66a3, 1); popd(esi);                              /* pop esi */
            ii(0x1008_66a4, 1); popd(edx);                              /* pop edx */
            ii(0x1008_66a5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_66a6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_66a7, 1); retd(); return;                         /* ret */
        }
    }
}
