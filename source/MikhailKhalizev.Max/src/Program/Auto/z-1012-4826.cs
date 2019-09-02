using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4826-5d77ed62")]
        public void Method_1012_4826()
        {
            ii(0x1012_4826, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_482b, 5); call(Definitions.sys_check_available_stack_size, 0x4_1522); /* call 0x10165d52 */
            ii(0x1012_4830, 1); push(ebx);                              /* push ebx */
            ii(0x1012_4831, 1); push(ecx);                              /* push ecx */
            ii(0x1012_4832, 1); push(edx);                              /* push edx */
            ii(0x1012_4833, 1); push(esi);                              /* push esi */
            ii(0x1012_4834, 1); push(edi);                              /* push edi */
            ii(0x1012_4835, 1); push(ebp);                              /* push ebp */
            ii(0x1012_4836, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4838, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_483e, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x1012_4841, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_4848, 2); jmp(0x1012_4850, 6); goto l_0x1012_4850; /* jmp 0x10124850 */
        l_0x1012_484a:
            ii(0x1012_484a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_484d, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x1012_4850:
            ii(0x1012_4850, 4); cmp(memd[ss, ebp - 8], 0x10);           /* cmp dword [ebp-0x8], 0x10 */
            ii(0x1012_4854, 2); if(jae(0x1012_487a, 0x24)) goto l_0x1012_487a; /* jae 0x1012487a */
            ii(0x1012_4856, 5); mov(eax, memd[ds, 0x101b_b420]);        /* mov eax, [0x101bb420] */
            ii(0x1012_485b, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1012_485e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_4860, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1012_4862, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_4864, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1012_4867, 5); call(Definitions.sys_tolower, 0x4_e229); /* call 0x10172a95 */
            ii(0x1012_486c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_486e, 2); if(jnz(0x1012_4878, 8)) goto l_0x1012_4878; /* jnz 0x10124878 */
            ii(0x1012_4870, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_4873, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_4876, 2); jmp(0x1012_4881, 9); goto l_0x1012_4881; /* jmp 0x10124881 */
        l_0x1012_4878:
            ii(0x1012_4878, 2); jmp(0x1012_484a, -0x30); goto l_0x1012_484a; /* jmp 0x1012484a */
        l_0x1012_487a:
            ii(0x1012_487a, 7); mov(memd[ss, ebp - 0xc], 0xffff_ffff);  /* mov dword [ebp-0xc], 0xffffffff */
        l_0x1012_4881:
            ii(0x1012_4881, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_4884, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_4886, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_4887, 1); pop(edi);                               /* pop edi */
            ii(0x1012_4888, 1); pop(esi);                               /* pop esi */
            ii(0x1012_4889, 1); pop(edx);                               /* pop edx */
            ii(0x1012_488a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_488b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_488c, 1); ret();                                  /* ret */
        }
    }
}
