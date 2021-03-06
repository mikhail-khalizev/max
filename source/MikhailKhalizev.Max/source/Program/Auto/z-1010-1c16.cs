using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_1c16-8713e08e")]
        public void Method_1010_1c16()
        {
            ii(0x1010_1c16, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1010_1c1b, 5);  call(Definitions.sys_check_available_stack_size, 0x6_4132);/* call 0x10165d52 */
            ii(0x1010_1c20, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_1c21, 1);  push(esi);                            /* push esi */
            ii(0x1010_1c22, 1);  push(edi);                            /* push edi */
            ii(0x1010_1c23, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_1c24, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_1c26, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1010_1c2c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_1c2f, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1010_1c32, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1010_1c35, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1c38, 3);  dec(memw[ds, eax]);                   /* dec word [eax] */
            ii(0x1010_1c3b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1c3e, 5);  add(memw[ds, eax + 2], 2);            /* add word [eax+0x2], 0x2 */
            ii(0x1010_1c43, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1010_1c4a, 2);  jmp(0x1010_1c50, 4); goto l_0x1010_1c50;/* jmp 0x10101c50 */
        l_0x1010_1c4c:
            ii(0x1010_1c4c, 4);  add(memd[ss, ebp - 20], 2);           /* add dword [ebp-0x14], 0x2 */
        l_0x1010_1c50:
            ii(0x1010_1c50, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_1c54, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1010_1c57, 6);  if(jge(0x1010_1cdc, 0x7f)) goto l_0x1010_1cdc;/* jge 0x10101cdc */
            ii(0x1010_1c5d, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_1c64, 2);  jmp(0x1010_1c6c, 6); goto l_0x1010_1c6c;/* jmp 0x10101c6c */
        l_0x1010_1c66:
            ii(0x1010_1c66, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_1c69, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1010_1c6c:
            ii(0x1010_1c6c, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_1c70, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1010_1c73, 2);  if(jge(0x1010_1cc1, 0x4c)) goto l_0x1010_1cc1;/* jge 0x10101cc1 */
            ii(0x1010_1c75, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1010_1c79, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1010_1c7c, 5);  mov(eax, 0x101c_5348);                /* mov eax, 0x101c5348 */
            ii(0x1010_1c81, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_1c83, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1c86, 5);  call(0x1008_b1a4, -0x7_6ae7);         /* call 0x1008b1a4 */
            ii(0x1010_1c8b, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x1010_1c90, 1);  push(eax);                            /* push eax */
            ii(0x1010_1c91, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1c94, 2);  mov(ecx, memd[ds, eax]);              /* mov ecx, [eax] */
            ii(0x1010_1c96, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1010_1c99, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1c9c, 3);  movsx(ebx, memw[ds, eax]);            /* movsx ebx, word [eax] */
            ii(0x1010_1c9f, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1010_1ca3, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x1010_1ca8, 5);  call(0x1007_02b9, -0x9_19f4);         /* call 0x100702b9 */
            ii(0x1010_1cad, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x1010_1cb0, 2);  if(jz(0x1010_1cbf, 0xd)) goto l_0x1010_1cbf;/* jz 0x10101cbf */
            ii(0x1010_1cb2, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_1cb5, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_1cb8, 5);  call(0x1007_5e64, -0x8_be59);         /* call 0x10075e64 */
            ii(0x1010_1cbd, 2);  jmp(0x1010_1cee, 0x2f); goto l_0x1010_1cee;/* jmp 0x10101cee */
        l_0x1010_1cbf:
            ii(0x1010_1cbf, 2);  jmp(0x1010_1c66, -0x5b); goto l_0x1010_1c66;/* jmp 0x10101c66 */
        l_0x1010_1cc1:
            ii(0x1010_1cc1, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_1cc5, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_1cc8, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x1010_1ccd, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_1ccf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1cd2, 5);  call(0x1008_b1a4, -0x7_6b33);         /* call 0x1008b1a4 */
            ii(0x1010_1cd7, 5);  jmp(0x1010_1c4c, -0x90); goto l_0x1010_1c4c;/* jmp 0x10101c4c */
        l_0x1010_1cdc:
            ii(0x1010_1cdc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1cdf, 4);  dec(memw[ds, eax + 2]);               /* dec word [eax+0x2] */
            ii(0x1010_1ce3, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_1ce6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_1ce9, 5);  call(0x1007_5e64, -0x8_be8a);         /* call 0x10075e64 */
        l_0x1010_1cee:
            ii(0x1010_1cee, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_1cf1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_1cf3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_1cf4, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_1cf5, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_1cf6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_1cf7, 1);  ret();                                /* ret */
        }
    }
}
