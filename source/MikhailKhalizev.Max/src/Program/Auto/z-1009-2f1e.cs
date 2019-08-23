using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_2f1e-e1d61d12")]
        public void Method_1009_2f1e()
        {
            ii(0x1009_2f1e, 5); push(0x30);                             /* push 0x30 */
            ii(0x1009_2f23, 5); call(Definitions.sys_check_available_stack_size, 0xd_2e2a); /* call 0x10165d52 */
            ii(0x1009_2f28, 1); push(ecx);                              /* push ecx */
            ii(0x1009_2f29, 1); push(esi);                              /* push esi */
            ii(0x1009_2f2a, 1); push(edi);                              /* push edi */
            ii(0x1009_2f2b, 1); push(ebp);                              /* push ebp */
            ii(0x1009_2f2c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_2f2e, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1009_2f34, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_2f37, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_2f3a, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1009_2f3d, 5); mov(ecx, 0x1d00);                       /* mov ecx, 0x1d00 */
            ii(0x1009_2f42, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_2f44, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1009_2f48, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_2f4b, 5); call(0x100a_26d1, 0xf781);              /* call 0x100a26d1 */
            ii(0x1009_2f50, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_2f53, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_2f56, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_2f59, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_2f5c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_2f5f, 5); call(Definitions.my_ctor_0x101b_4184, -0x1_c474); /* call 0x10076af0 */
            ii(0x1009_2f64, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_2f67, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_2f6a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_2f6d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_2f70, 5); call(Definitions.my_ctor_0x101b_56fc, -0xa2f9); /* call 0x10088c7c */
            ii(0x1009_2f75, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x1009_2f78, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_2f7b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_2f7e, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_2f81, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_2f84, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_2f87, 5); call(0x1009_c6fc, 0x9770);              /* call 0x1009c6fc */
            ii(0x1009_2f8c, 3); sub(eax, 0x21);                         /* sub eax, 0x21 */
            ii(0x1009_2f8f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_2f92, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_2f95, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_2f98, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_2f9b, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1009_2f9e, 5); call(0x1007_20b1, -0x2_0ef2);           /* call 0x100720b1 */
            ii(0x1009_2fa3, 3); sub(eax, 0x2b);                         /* sub eax, 0x2b */
            ii(0x1009_2fa6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_2fa9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_2fac, 7); mov(memd[ds, eax + 0x2], 0x101b_45e8);  /* mov dword [eax+0x2], 0x101b45e8 */
            ii(0x1009_2fb3, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_2fb6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_2fb9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_2fbc, 5); call(0x1008_8b44, -0xa47d);             /* call 0x10088b44 */
            ii(0x1009_2fc1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_2fc4, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_2fc7, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_2fca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_2fcc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_2fcd, 1); pop(edi);                               /* pop edi */
            ii(0x1009_2fce, 1); pop(esi);                               /* pop esi */
            ii(0x1009_2fcf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_2fd0, 1); ret();                                  /* ret */
        }
    }
}
