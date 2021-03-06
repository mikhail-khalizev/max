using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_d950-453826bb")]
        public void Method_100e_d950()
        {
            ii(0x100e_d950, 5);  push(0x38);                           /* push 0x38 */
            ii(0x100e_d955, 5);  call(Definitions.sys_check_available_stack_size, 0x7_83f8);/* call 0x10165d52 */
            ii(0x100e_d95a, 1);  push(esi);                            /* push esi */
            ii(0x100e_d95b, 1);  push(edi);                            /* push edi */
            ii(0x100e_d95c, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_d95d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_d95f, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100e_d965, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_d968, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100e_d96b, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100e_d96e, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x100e_d971, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x100e_d977, 1);  inc(eax);                             /* inc eax */
            ii(0x100e_d978, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_d97b, 4);  movsx(edx, memw[ss, ebp + 20]);       /* movsx edx, word [ebp+0x14] */
            ii(0x100e_d97f, 4);  movsx(ebx, memw[ss, ebp - 20]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x100e_d983, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_d985, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_d988, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100e_d98a, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_d98d, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100e_d991, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100e_d993, 2);  if(jz(0x100e_d99b, 6)) goto l_0x100e_d99b;/* jz 0x100ed99b */
            ii(0x100e_d995, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100e_d999, 2);  if(jnz(0x100e_d9a0, 5)) goto l_0x100e_d9a0;/* jnz 0x100ed9a0 */
        l_0x100e_d99b:
            ii(0x100e_d99b, 5);  jmp(0x100e_da4a, 0xaa); goto l_0x100e_da4a;/* jmp 0x100eda4a */
        l_0x100e_d9a0:
            ii(0x100e_d9a0, 3);  lea(ecx, memd[ss, ebp - 28]);         /* lea ecx, [ebp-0x1c] */
            ii(0x100e_d9a3, 4);  movsx(ebx, memw[ss, ebp + 16]);       /* movsx ebx, word [ebp+0x10] */
            ii(0x100e_d9a7, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100e_d9ab, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_d9ae, 5);  call(0x100e_969d, -0x4316);           /* call 0x100e969d */
            ii(0x100e_d9b3, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_d9b6, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100e_d9ba, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_d9be, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100e_d9c1, 4);  movsx(eax, memw[ss, ebp + 20]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100e_d9c5, 1);  inc(eax);                             /* inc eax */
            ii(0x100e_d9c6, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_d9c8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_d9ca, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_d9cc, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_d9cf, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_d9d1, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100e_d9d3, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100e_d9d7, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100e_d9d9, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100e_d9dc, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_d9df, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_d9e2, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_d9e9, 2);  jmp(0x100e_d9f1, 6); goto l_0x100e_d9f1;/* jmp 0x100ed9f1 */
        l_0x100e_d9eb:
            ii(0x100e_d9eb, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_d9ee, 3);  inc(memd[ss, ebp - 28]);              /* inc dword [ebp-0x1c] */
        l_0x100e_d9f1:
            ii(0x100e_d9f1, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_d9f4, 4);  cmp(ax, memw[ss, ebp - 24]);          /* cmp ax, [ebp-0x18] */
            ii(0x100e_d9f8, 2);  if(jge(0x100e_da32, 0x38)) goto l_0x100e_da32;/* jge 0x100eda32 */
            ii(0x100e_d9fa, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100e_d9fe, 1);  push(eax);                            /* push eax */
            ii(0x100e_d9ff, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100e_da03, 1);  push(eax);                            /* push eax */
            ii(0x100e_da04, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_da07, 4);  imul(eax, memd[ss, ebp - 20]);        /* imul eax, [ebp-0x14] */
            ii(0x100e_da0b, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x100e_da0e, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100e_da11, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100e_da15, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_da19, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100e_da1c, 3);  add(eax, memd[ss, ebp - 32]);         /* add eax, [ebp-0x20] */
            ii(0x100e_da1f, 5);  call(Definitions.my_strobj_c_str_v2, -0x6_425c);/* call 0x100897c8 */
            ii(0x100e_da24, 3);  mov(esi, memd[ss, ebp - 16]);         /* mov esi, [ebp-0x10] */
            ii(0x100e_da27, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_da29, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x100e_da2b, 5);  call(0x100e_d76b, -0x2c5);            /* call 0x100ed76b */
            ii(0x100e_da30, 2);  jmp(0x100e_d9eb, -0x47); goto l_0x100e_d9eb;/* jmp 0x100ed9eb */
        l_0x100e_da32:
            ii(0x100e_da32, 4);  cmp(memd[ss, ebp - 32], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100e_da36, 2);  if(jz(0x100e_da4a, 0x12)) goto l_0x100e_da4a;/* jz 0x100eda4a */
            ii(0x100e_da38, 5);  mov(edx, 0x101b_5c10);                /* mov edx, 0x101b5c10 */
            ii(0x100e_da3d, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_da40, 5);  call(Definitions.sys_call_dtor_arr, 0x7_8573);/* call 0x10165fb8 */
            ii(0x100e_da45, 5);  call(Definitions.sys_delete_arr, 0x7_858e);/* call 0x10165fd8 */
        l_0x100e_da4a:
            ii(0x100e_da4a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_da4c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_da4d, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_da4e, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_da4f, 3);  ret(0xc);                             /* ret 0xc */
        }
    }
}
