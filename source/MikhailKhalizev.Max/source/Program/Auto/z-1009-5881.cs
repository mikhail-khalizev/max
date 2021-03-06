using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_5881-37013399")]
        public void Method_1009_5881()
        {
            ii(0x1009_5881, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1009_5886, 5);  call(Definitions.sys_check_available_stack_size, 0xd_04c7);/* call 0x10165d52 */
            ii(0x1009_588b, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_588c, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_588d, 1);  push(esi);                            /* push esi */
            ii(0x1009_588e, 1);  push(edi);                            /* push edi */
            ii(0x1009_588f, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_5890, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_5892, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1009_5898, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_589b, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_589e, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1009_58a3, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1009_58a8, 5);  mov(edx, 0x3d);                       /* mov edx, 0x3d */
            ii(0x1009_58ad, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_58b0, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_58b3, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_58b6, 6);  imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
            ii(0x1009_58bc, 5);  mov(esi, 0x101c_31c4);                /* mov esi, 0x101c31c4 */
            ii(0x1009_58c1, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1009_58c3, 5);  call(0x100c_204f, 0x2_c787);          /* call 0x100c204f */
            ii(0x1009_58c8, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_58cb, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1009_58cf, 6);  if(jz(0x1009_593f, 0x6a)) goto l_0x1009_593f;/* jz 0x1009593f */
            ii(0x1009_58d5, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1009_58dc, 2);  jmp(0x1009_58e4, 6); goto l_0x1009_58e4;/* jmp 0x100958e4 */
        l_0x1009_58de:
            ii(0x1009_58de, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_58e1, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1009_58e4:
            ii(0x1009_58e4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_58e7, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1009_58ee, 2);  if(jge(0x1009_593f, 0x4f)) goto l_0x1009_593f;/* jge 0x1009593f */
            ii(0x1009_58f0, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1009_58f7, 2);  jmp(0x1009_58ff, 6); goto l_0x1009_58ff;/* jmp 0x100958ff */
        l_0x1009_58f9:
            ii(0x1009_58f9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_58fc, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1009_58ff:
            ii(0x1009_58ff, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_5902, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1009_5909, 2);  if(jge(0x1009_593d, 0x32)) goto l_0x1009_593d;/* jge 0x1009593d */
            ii(0x1009_590b, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_590f, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_5912, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x1009_5915, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1009_5919, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1009_591b, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_591d, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_591f, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_5922, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_5924, 2);  if(jle(0x1009_593b, 0x15)) goto l_0x1009_593b;/* jle 0x1009593b */
            ii(0x1009_5926, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_592a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_592d, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_5930, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1009_5934, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_5936, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_5938, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x1009_593b:
            ii(0x1009_593b, 2);  jmp(0x1009_58f9, -0x44); goto l_0x1009_58f9;/* jmp 0x100958f9 */
        l_0x1009_593d:
            ii(0x1009_593d, 2);  jmp(0x1009_58de, -0x61); goto l_0x1009_58de;/* jmp 0x100958de */
        l_0x1009_593f:
            ii(0x1009_593f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_5941, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_5942, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_5943, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_5944, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_5945, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_5946, 1);  ret();                                /* ret */
        }
    }
}
