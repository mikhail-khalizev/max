using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_a330-662a919f")]
        public void Method_1011_a330()
        {
            ii(0x1011_a330, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1011_a335, 5);  call(Definitions.sys_check_available_stack_size, 0x4_ba18);/* call 0x10165d52 */
            ii(0x1011_a33a, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_a33b, 1);  push(esi);                            /* push esi */
            ii(0x1011_a33c, 1);  push(edi);                            /* push edi */
            ii(0x1011_a33d, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_a33e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_a340, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1011_a346, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_a349, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_a34c, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1011_a34f, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_a351, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_a353, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_a356, 5);  call(0x1007_6aac, -0xa_38af);         /* call 0x10076aac */
            ii(0x1011_a35b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_a35e, 4);  mov(ax, memw[ds, eax + 22]);          /* mov ax, [eax+0x16] */
            ii(0x1011_a362, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_a365, 2);  jmp(0x1011_a36d, 6); goto l_0x1011_a36d;/* jmp 0x1011a36d */
        l_0x1011_a367:
            ii(0x1011_a367, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_a36a, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x1011_a36d:
            ii(0x1011_a36d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_a370, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_a373, 5);  call(0x100b_82bc, -0x6_20bc);         /* call 0x100b82bc */
            ii(0x1011_a378, 4);  cmp(ax, memw[ss, ebp - 20]);          /* cmp ax, [ebp-0x14] */
            ii(0x1011_a37c, 2);  if(jle(0x1011_a3c9, 0x4b)) goto l_0x1011_a3c9;/* jle 0x1011a3c9 */
            ii(0x1011_a37e, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_a381, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1011_a385, 2);  if(jnz(0x1011_a390, 9)) goto l_0x1011_a390;/* jnz 0x1011a390 */
            ii(0x1011_a387, 3);  mov(eax, memd[ss, ebp - 22]);         /* mov eax, [ebp-0x16] */
            ii(0x1011_a38a, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1011_a38e, 2);  if(jz(0x1011_a392, 2)) goto l_0x1011_a392;/* jz 0x1011a392 */
        l_0x1011_a390:
            ii(0x1011_a390, 2);  jmp(0x1011_a398, 6); goto l_0x1011_a398;/* jmp 0x1011a398 */
        l_0x1011_a392:
            ii(0x1011_a392, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1011_a396, 2);  jmp(0x1011_a3ed, 0x55); goto l_0x1011_a3ed;/* jmp 0x1011a3ed */
        l_0x1011_a398:
            ii(0x1011_a398, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1011_a39c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_a39f, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_a3a2, 5);  call(0x100b_827c, -0x6_212b);         /* call 0x100b827c */
            ii(0x1011_a3a7, 4);  movsx(ax, memb[ds, eax]);             /* movsx ax, byte [eax] */
            ii(0x1011_a3ab, 4);  add(memw[ss, ebp - 24], ax);          /* add [ebp-0x18], ax */
            ii(0x1011_a3af, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1011_a3b3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_a3b6, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_a3b9, 5);  call(0x100b_827c, -0x6_2142);         /* call 0x100b827c */
            ii(0x1011_a3be, 5);  movsx(ax, memb[ds, eax + 1]);         /* movsx ax, byte [eax+0x1] */
            ii(0x1011_a3c3, 4);  add(memw[ss, ebp - 22], ax);          /* add [ebp-0x16], ax */
            ii(0x1011_a3c7, 2);  jmp(0x1011_a367, -0x62); goto l_0x1011_a367;/* jmp 0x1011a367 */
        l_0x1011_a3c9:
            ii(0x1011_a3c9, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_a3cc, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1011_a3d0, 2);  if(jnz(0x1011_a3db, 9)) goto l_0x1011_a3db;/* jnz 0x1011a3db */
            ii(0x1011_a3d2, 3);  mov(eax, memd[ss, ebp - 22]);         /* mov eax, [ebp-0x16] */
            ii(0x1011_a3d5, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1011_a3d9, 2);  if(jz(0x1011_a3dd, 2)) goto l_0x1011_a3dd;/* jz 0x1011a3dd */
        l_0x1011_a3db:
            ii(0x1011_a3db, 2);  jmp(0x1011_a3e3, 6); goto l_0x1011_a3e3;/* jmp 0x1011a3e3 */
        l_0x1011_a3dd:
            ii(0x1011_a3dd, 4);  mov(memb[ss, ebp - 28], 1);           /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1011_a3e1, 2);  jmp(0x1011_a3e7, 4); goto l_0x1011_a3e7;/* jmp 0x1011a3e7 */
        l_0x1011_a3e3:
            ii(0x1011_a3e3, 4);  mov(memb[ss, ebp - 28], 0);           /* mov byte [ebp-0x1c], 0x0 */
        l_0x1011_a3e7:
            ii(0x1011_a3e7, 3);  mov(al, memb[ss, ebp - 28]);          /* mov al, [ebp-0x1c] */
            ii(0x1011_a3ea, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
        l_0x1011_a3ed:
            ii(0x1011_a3ed, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1011_a3f0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_a3f2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_a3f3, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_a3f4, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_a3f5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_a3f6, 1);  ret();                                /* ret */
        }
    }
}
