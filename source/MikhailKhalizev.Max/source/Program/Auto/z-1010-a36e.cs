using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_a36e-421fb1b2")]
        public void Method_1010_a36e()
        {
            ii(0x1010_a36e, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1010_a373, 5);  call(Definitions.sys_check_available_stack_size, 0x5_b9da);/* call 0x10165d52 */
            ii(0x1010_a378, 1);  push(esi);                            /* push esi */
            ii(0x1010_a379, 1);  push(edi);                            /* push edi */
            ii(0x1010_a37a, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_a37b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_a37d, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1010_a383, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_a386, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1010_a389, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1010_a38c, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
        l_0x1010_a38f:
            ii(0x1010_a38f, 3);  dec(memd[ss, ebp - 12]);              /* dec dword [ebp-0xc] */
            ii(0x1010_a392, 5);  cmp(memw[ss, ebp - 12], -1 /* 0xff */);/* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_a397, 2);  if(jz(0x1010_a3f6, 0x5d)) goto l_0x1010_a3f6;/* jz 0x1010a3f6 */
            ii(0x1010_a399, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a39c, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_a39f, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_a3a2, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_a3a7, 5);  mov(edx, 0x101c_4e50);                /* mov edx, 0x101c4e50 */
            ii(0x1010_a3ac, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_a3af, 5);  call(0x100d_4d78, -0x3_563c);         /* call 0x100d4d78 */
            ii(0x1010_a3b4, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1010_a3b6, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_a3ba, 3);  imul(eax, eax, 0x14);                 /* imul eax, eax, 0x14 */
            ii(0x1010_a3bd, 5);  mov(edx, 0x101b_a5ac);                /* mov edx, 0x101ba5ac */
            ii(0x1010_a3c2, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_a3c4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_a3c7, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_a3c9, 5);  call(0x1010_a2d7, -0xf7);             /* call 0x1010a2d7 */
            ii(0x1010_a3ce, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_a3d1, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1010_a3d5, 2);  if(jnz(0x1010_a3f4, 0x1d)) goto l_0x1010_a3f4;/* jnz 0x1010a3f4 */
            ii(0x1010_a3d7, 5);  mov(ebx, 0xff);                       /* mov ebx, 0xff */
            ii(0x1010_a3dc, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_a3e0, 3);  imul(eax, eax, 0x14);                 /* imul eax, eax, 0x14 */
            ii(0x1010_a3e3, 5);  mov(edx, 0x101b_a5ac);                /* mov edx, 0x101ba5ac */
            ii(0x1010_a3e8, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_a3ea, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_a3ed, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_a3ef, 5);  call(0x1010_89b0, -0x1a44);           /* call 0x101089b0 */
        l_0x1010_a3f4:
            ii(0x1010_a3f4, 2);  jmp(0x1010_a38f, -0x67); goto l_0x1010_a38f;/* jmp 0x1010a38f */
        l_0x1010_a3f6:
            ii(0x1010_a3f6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_a3f8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_a3f9, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_a3fa, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_a3fb, 1);  ret();                                /* ret */
        }
    }
}
