using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_fd69-e1545f8c")]
        public void Method_100d_fd69()
        {
            ii(0x100d_fd69, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100d_fd6e, 5);  call(Definitions.sys_check_available_stack_size, 0x8_5fdf);/* call 0x10165d52 */
            ii(0x100d_fd73, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_fd74, 1);  push(esi);                            /* push esi */
            ii(0x100d_fd75, 1);  push(edi);                            /* push edi */
            ii(0x100d_fd76, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_fd77, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_fd79, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100d_fd7f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_fd82, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100d_fd85, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100d_fd88, 4);  movsx(ebx, memb[ss, ebp - 4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x100d_fd8c, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100d_fd90, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fd94, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100d_fd9a, 6);  mov(eax, memd[ds, eax + 0x101c_a562]);/* mov eax, [eax+0x101ca562] */
            ii(0x100d_fda0, 5);  call(0x100c_b6b0, -0x1_46f5);         /* call 0x100cb6b0 */
            ii(0x100d_fda5, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x100d_fda7, 5);  call(0x1016_3b41, 0x8_3d95);          /* call 0x10163b41 */
            ii(0x100d_fdac, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100d_fdaf, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_fdb2, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_fdb6, 3);  cmp(eax, 0xa);                        /* cmp eax, 0xa */
            ii(0x100d_fdb9, 2);  if(jge(0x100d_fdc4, 9)) goto l_0x100d_fdc4;/* jge 0x100dfdc4 */
            ii(0x100d_fdbb, 7);  mov(memd[ss, ebp - 20], 1);           /* mov dword [ebp-0x14], 0x1 */
            ii(0x100d_fdc2, 2);  jmp(0x100d_fdef, 0x2b); goto l_0x100d_fdef;/* jmp 0x100dfdef */
        l_0x100d_fdc4:
            ii(0x100d_fdc4, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_fdc8, 3);  cmp(eax, 0x19);                       /* cmp eax, 0x19 */
            ii(0x100d_fdcb, 2);  if(jge(0x100d_fdd6, 9)) goto l_0x100d_fdd6;/* jge 0x100dfdd6 */
            ii(0x100d_fdcd, 7);  mov(memd[ss, ebp - 20], 2);           /* mov dword [ebp-0x14], 0x2 */
            ii(0x100d_fdd4, 2);  jmp(0x100d_fdef, 0x19); goto l_0x100d_fdef;/* jmp 0x100dfdef */
        l_0x100d_fdd6:
            ii(0x100d_fdd6, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_fdda, 3);  cmp(eax, 0x32);                       /* cmp eax, 0x32 */
            ii(0x100d_fddd, 2);  if(jge(0x100d_fde8, 9)) goto l_0x100d_fde8;/* jge 0x100dfde8 */
            ii(0x100d_fddf, 7);  mov(memd[ss, ebp - 20], 5);           /* mov dword [ebp-0x14], 0x5 */
            ii(0x100d_fde6, 2);  jmp(0x100d_fdef, 7); goto l_0x100d_fdef;/* jmp 0x100dfdef */
        l_0x100d_fde8:
            ii(0x100d_fde8, 7);  mov(memd[ss, ebp - 20], 0xa);         /* mov dword [ebp-0x14], 0xa */
        l_0x100d_fdef:
            ii(0x100d_fdef, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_fdf2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_fdf4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_fdf5, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_fdf6, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_fdf7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_fdf8, 1);  ret();                                /* ret */
        }
    }
}
