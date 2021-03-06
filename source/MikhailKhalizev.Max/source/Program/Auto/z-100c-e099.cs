using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_e099-9b03f781")]
        public void Method_100c_e099()
        {
            ii(0x100c_e099, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_e09e, 5);  call(Definitions.sys_check_available_stack_size, 0x9_7caf);/* call 0x10165d52 */
            ii(0x100c_e0a3, 1);  push(esi);                            /* push esi */
            ii(0x100c_e0a4, 1);  push(edi);                            /* push edi */
            ii(0x100c_e0a5, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_e0a6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_e0a8, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100c_e0ae, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_e0b1, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100c_e0b4, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100c_e0b7, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100c_e0ba, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100c_e0be, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_e0c0, 2);  if(jl(0x100c_e0ca, 8)) goto l_0x100c_e0ca;/* jl 0x100ce0ca */
            ii(0x100c_e0c2, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100c_e0c6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_e0c8, 2);  if(jge(0x100c_e0cc, 2)) goto l_0x100c_e0cc;/* jge 0x100ce0cc */
        l_0x100c_e0ca:
            ii(0x100c_e0ca, 2);  jmp(0x100c_e0df, 0x13); goto l_0x100c_e0df;/* jmp 0x100ce0df */
        l_0x100c_e0cc:
            ii(0x100c_e0cc, 5);  mov(eax, memd[ds, 0x101c_8170]);      /* mov eax, [0x101c8170] */
            ii(0x100c_e0d1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_e0d4, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_e0d8, 3);  sub(eax, 2);                          /* sub eax, 0x2 */
            ii(0x100c_e0db, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100c_e0dd, 2);  if(jle(0x100c_e0e1, 2)) goto l_0x100c_e0e1;/* jle 0x100ce0e1 */
        l_0x100c_e0df:
            ii(0x100c_e0df, 2);  jmp(0x100c_e0f4, 0x13); goto l_0x100c_e0f4;/* jmp 0x100ce0f4 */
        l_0x100c_e0e1:
            ii(0x100c_e0e1, 5);  mov(eax, memd[ds, 0x101c_8170]);      /* mov eax, [0x101c8170] */
            ii(0x100c_e0e6, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_e0e9, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100c_e0ed, 3);  sub(eax, 2);                          /* sub eax, 0x2 */
            ii(0x100c_e0f0, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100c_e0f2, 2);  if(jle(0x100c_e0fd, 9)) goto l_0x100c_e0fd;/* jle 0x100ce0fd */
        l_0x100c_e0f4:
            ii(0x100c_e0f4, 4);  mov(memb[ss, ebp - 20], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100c_e0f8, 5);  jmp(0x100c_e199, 0x9c); goto l_0x100c_e199;/* jmp 0x100ce199 */
        l_0x100c_e0fd:
            ii(0x100c_e0fd, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x100c_e102, 1);  push(eax);                            /* push eax */
            ii(0x100c_e103, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100c_e107, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100c_e10b, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_e10f, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100c_e113, 5);  call(0x1007_02b9, -0x5_de5f);         /* call 0x100702b9 */
            ii(0x100c_e118, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x100c_e11b, 2);  if(jz(0x100c_e140, 0x23)) goto l_0x100c_e140;/* jz 0x100ce140 */
            ii(0x100c_e11d, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x100c_e122, 1);  push(eax);                            /* push eax */
            ii(0x100c_e123, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100c_e127, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_e12a, 1);  inc(eax);                             /* inc eax */
            ii(0x100c_e12b, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100c_e12e, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_e132, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100c_e136, 5);  call(0x1007_02b9, -0x5_de82);         /* call 0x100702b9 */
            ii(0x100c_e13b, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x100c_e13e, 2);  if(jnz(0x100c_e142, 2)) goto l_0x100c_e142;/* jnz 0x100ce142 */
        l_0x100c_e140:
            ii(0x100c_e140, 2);  jmp(0x100c_e165, 0x23); goto l_0x100c_e165;/* jmp 0x100ce165 */
        l_0x100c_e142:
            ii(0x100c_e142, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x100c_e147, 1);  push(eax);                            /* push eax */
            ii(0x100c_e148, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e14b, 1);  inc(eax);                             /* inc eax */
            ii(0x100c_e14c, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100c_e14f, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100c_e153, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_e157, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100c_e15b, 5);  call(0x1007_02b9, -0x5_dea7);         /* call 0x100702b9 */
            ii(0x100c_e160, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x100c_e163, 2);  if(jnz(0x100c_e167, 2)) goto l_0x100c_e167;/* jnz 0x100ce167 */
        l_0x100c_e165:
            ii(0x100c_e165, 2);  jmp(0x100c_e18d, 0x26); goto l_0x100c_e18d;/* jmp 0x100ce18d */
        l_0x100c_e167:
            ii(0x100c_e167, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x100c_e16c, 1);  push(eax);                            /* push eax */
            ii(0x100c_e16d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e170, 1);  inc(eax);                             /* inc eax */
            ii(0x100c_e171, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100c_e174, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_e177, 1);  inc(eax);                             /* inc eax */
            ii(0x100c_e178, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100c_e17b, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_e17f, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100c_e183, 5);  call(0x1007_02b9, -0x5_decf);         /* call 0x100702b9 */
            ii(0x100c_e188, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x100c_e18b, 2);  if(jnz(0x100c_e18f, 2)) goto l_0x100c_e18f;/* jnz 0x100ce18f */
        l_0x100c_e18d:
            ii(0x100c_e18d, 2);  jmp(0x100c_e195, 6); goto l_0x100c_e195;/* jmp 0x100ce195 */
        l_0x100c_e18f:
            ii(0x100c_e18f, 4);  mov(memb[ss, ebp - 20], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x100c_e193, 2);  jmp(0x100c_e199, 4); goto l_0x100c_e199;/* jmp 0x100ce199 */
        l_0x100c_e195:
            ii(0x100c_e195, 4);  mov(memb[ss, ebp - 20], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x100c_e199:
            ii(0x100c_e199, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x100c_e19c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_e19e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_e19f, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_e1a0, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_e1a1, 1);  ret();                                /* ret */
        }
    }
}
