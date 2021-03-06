using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_9f56-b11e60ac")]
        public void my_ctor_c20()
        {
            ii(0x1011_9f56, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1011_9f5b, 5);  call(Definitions.sys_check_available_stack_size, 0x4_bdf2);/* call 0x10165d52 */
            ii(0x1011_9f60, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_9f61, 1);  push(esi);                            /* push esi */
            ii(0x1011_9f62, 1);  push(edi);                            /* push edi */
            ii(0x1011_9f63, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_9f64, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_9f66, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1011_9f6c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_9f6f, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_9f72, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1011_9f75, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1011_9f79, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1011_9f7d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9f80, 5);  call(0x1011_80b5, -0x1ed0);           /* call 0x101180b5 */
            ii(0x1011_9f85, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_9f88, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1011_9f8b, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_9f8e, 5);  call(0x100b_83a8, -0x6_1beb);         /* call 0x100b83a8 */
            ii(0x1011_9f93, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_9f96, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9f99, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_9f9c, 5);  call(0x100b_8340, -0x6_1c61);         /* call 0x100b8340 */
            ii(0x1011_9fa1, 3);  sub(eax, 0x18);                       /* sub eax, 0x18 */
            ii(0x1011_9fa4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_9fa7, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1011_9faa, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_9fad, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9fb0, 7);  mov(memd[ds, eax + 2], 0x101b_6924);  /* mov dword [eax+0x2], 0x101b6924 */
            ii(0x1011_9fb7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9fba, 6);  mov(memw[ds, eax + 22], 0);           /* mov word [eax+0x16], 0x0 */
            ii(0x1011_9fc0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9fc3, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_9fc6, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_9fc9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_9fcb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_9fcc, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_9fcd, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_9fce, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_9fcf, 1);  ret();                                /* ret */
        }
    }
}
