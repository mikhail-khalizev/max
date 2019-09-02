using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1f63-4ed12467")]
        public void my_string_tolower()
        {
            ii(0x1014_1f63, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_1f68, 5); call(Definitions.sys_check_available_stack_size, 0x2_3de5); /* call 0x10165d52 */
            ii(0x1014_1f6d, 1); push(ebx);                              /* push ebx */
            ii(0x1014_1f6e, 1); push(ecx);                              /* push ecx */
            ii(0x1014_1f6f, 1); push(edx);                              /* push edx */
            ii(0x1014_1f70, 1); push(esi);                              /* push esi */
            ii(0x1014_1f71, 1); push(edi);                              /* push edi */
            ii(0x1014_1f72, 1); push(ebp);                              /* push ebp */
            ii(0x1014_1f73, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1f75, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_1f7b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_1f7e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_1f81, 5); call(Definitions.my_string_make_single_ref, 0x3d6); /* call 0x1014235c */
            ii(0x1014_1f86, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_1f89, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_1f8b, 5); call(Definitions.my_strobj_c_str, -0xb_8794); /* call 0x100897fc */
            ii(0x1014_1f90, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_1f93, 2); jmp(0x1014_1f9b, 6); goto l_0x1014_1f9b; /* jmp 0x10141f9b */
        l_0x1014_1f95:
            ii(0x1014_1f95, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1f98, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x1014_1f9b:
            ii(0x1014_1f9b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1f9e, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1014_1fa1, 2); if(jz(0x1014_1fbb, 0x18)) goto l_0x1014_1fbb; /* jz 0x10141fbb */
            ii(0x1014_1fa3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1fa6, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1014_1fa8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_1fad, 5); call(Definitions.sys_tolower, 0x3_0ae3); /* call 0x10172a95 */
            ii(0x1014_1fb2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_1fb4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1fb7, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
            ii(0x1014_1fb9, 2); jmp(0x1014_1f95, -0x26); goto l_0x1014_1f95; /* jmp 0x10141f95 */
        l_0x1014_1fbb:
            ii(0x1014_1fbb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_1fbe, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_1fc1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_1fc4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1fc6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_1fc7, 1); pop(edi);                               /* pop edi */
            ii(0x1014_1fc8, 1); pop(esi);                               /* pop esi */
            ii(0x1014_1fc9, 1); pop(edx);                               /* pop edx */
            ii(0x1014_1fca, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_1fcb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_1fcc, 1); ret();                                  /* ret */
        }
    }
}
