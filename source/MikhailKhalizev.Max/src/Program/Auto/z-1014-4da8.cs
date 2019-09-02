using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_4da8-654f82f2")]
        public void Method_1014_4da8()
        {
            ii(0x1014_4da8, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_4dad, 5); call(Definitions.sys_check_available_stack_size, 0x2_0fa0); /* call 0x10165d52 */
            ii(0x1014_4db2, 1); push(ebx);                              /* push ebx */
            ii(0x1014_4db3, 1); push(ecx);                              /* push ecx */
            ii(0x1014_4db4, 1); push(edx);                              /* push edx */
            ii(0x1014_4db5, 1); push(esi);                              /* push esi */
            ii(0x1014_4db6, 1); push(edi);                              /* push edi */
            ii(0x1014_4db7, 1); push(ebp);                              /* push ebp */
            ii(0x1014_4db8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_4dba, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_4dc0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_4dc3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_4dc6, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_4dc9, 5); call(0x1007_6998, -0xc_e436);           /* call 0x10076998 */
            ii(0x1014_4dce, 3); sub(eax, 0x4e);                         /* sub eax, 0x4e */
            ii(0x1014_4dd1, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_4dd4, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x1014_4dd7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_4dda, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_4ddd, 5); add(eax, 0x152);                        /* add eax, 0x152 */
            ii(0x1014_4de2, 5); call(0x1007_20b1, -0xd_2d36);           /* call 0x100720b1 */
            ii(0x1014_4de7, 5); sub(eax, 0x152);                        /* sub eax, 0x152 */
            ii(0x1014_4dec, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_4def, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_4df2, 5); add(eax, 0x15e);                        /* add eax, 0x15e */
            ii(0x1014_4df7, 5); call(0x1007_20b1, -0xd_2d4b);           /* call 0x100720b1 */
            ii(0x1014_4dfc, 5); sub(eax, 0x15e);                        /* sub eax, 0x15e */
            ii(0x1014_4e01, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_4e04, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_4e07, 5); add(eax, 0x16a);                        /* add eax, 0x16a */
            ii(0x1014_4e0c, 5); call(0x1007_20b1, -0xd_2d60);           /* call 0x100720b1 */
            ii(0x1014_4e11, 5); sub(eax, 0x16a);                        /* sub eax, 0x16a */
            ii(0x1014_4e16, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_4e19, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_4e1c, 5); add(eax, 0x176);                        /* add eax, 0x176 */
            ii(0x1014_4e21, 5); call(0x1007_20b1, -0xd_2d75);           /* call 0x100720b1 */
            ii(0x1014_4e26, 5); sub(eax, 0x176);                        /* sub eax, 0x176 */
            ii(0x1014_4e2b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_4e2e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_4e31, 5); add(eax, 0x182);                        /* add eax, 0x182 */
            ii(0x1014_4e36, 5); call(0x1007_20b1, -0xd_2d8a);           /* call 0x100720b1 */
            ii(0x1014_4e3b, 5); sub(eax, 0x182);                        /* sub eax, 0x182 */
            ii(0x1014_4e40, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_4e43, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_4e46, 5); add(eax, 0x18e);                        /* add eax, 0x18e */
            ii(0x1014_4e4b, 5); call(0x1007_20b1, -0xd_2d9f);           /* call 0x100720b1 */
            ii(0x1014_4e50, 5); sub(eax, 0x18e);                        /* sub eax, 0x18e */
            ii(0x1014_4e55, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_4e58, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_4e5b, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_4e5e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_4e61, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_4e63, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_4e64, 1); pop(edi);                               /* pop edi */
            ii(0x1014_4e65, 1); pop(esi);                               /* pop esi */
            ii(0x1014_4e66, 1); pop(edx);                               /* pop edx */
            ii(0x1014_4e67, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_4e68, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_4e69, 1); ret();                                  /* ret */
        }
    }
}
