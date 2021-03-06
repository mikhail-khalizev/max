using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_da02-7c643253")]
        public void Method_1011_da02()
        {
            ii(0x1011_da02, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1011_da07, 5);  call(Definitions.sys_check_available_stack_size, 0x4_8346);/* call 0x10165d52 */
            ii(0x1011_da0c, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_da0d, 1);  push(esi);                            /* push esi */
            ii(0x1011_da0e, 1);  push(edi);                            /* push edi */
            ii(0x1011_da0f, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_da10, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_da12, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1011_da18, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_da1b, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_da1e, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1011_da21, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_da24, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1011_da27, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1011_da2a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_da2d, 3);  mov(eax, memd[ds, eax + 39]);         /* mov eax, [eax+0x27] */
            ii(0x1011_da30, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_da32, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_da35, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_da37, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_da3a, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1011_da3c, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_da3e, 1);  dec(eax);                             /* dec eax */
            ii(0x1011_da3f, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        l_0x1011_da42:
            ii(0x1011_da42, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_da45, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1011_da49, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1011_da4d, 2);  if(jle(0x1011_da57, 8)) goto l_0x1011_da57;/* jle 0x1011da57 */
            ii(0x1011_da4f, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_da52, 3);  test(memb[ds, eax], 0x1f);            /* test byte [eax], 0x1f */
            ii(0x1011_da55, 2);  if(jnz(0x1011_da59, 2)) goto l_0x1011_da59;/* jnz 0x1011da59 */
        l_0x1011_da57:
            ii(0x1011_da57, 2);  jmp(0x1011_da61, 8); goto l_0x1011_da61;/* jmp 0x1011da61 */
        l_0x1011_da59:
            ii(0x1011_da59, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_da5c, 3);  test(memb[ds, eax], 0x20);            /* test byte [eax], 0x20 */
            ii(0x1011_da5f, 2);  if(jz(0x1011_da63, 2)) goto l_0x1011_da63;/* jz 0x1011da63 */
        l_0x1011_da61:
            ii(0x1011_da61, 2);  jmp(0x1011_da72, 0xf); goto l_0x1011_da72;/* jmp 0x1011da72 */
        l_0x1011_da63:
            ii(0x1011_da63, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_da66, 3);  dec(memd[ss, ebp - 20]);              /* dec dword [ebp-0x14] */
            ii(0x1011_da69, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_da6c, 4);  dec(memw[ds, eax + 2]);               /* dec word [eax+0x2] */
            ii(0x1011_da70, 2);  jmp(0x1011_da42, -0x30); goto l_0x1011_da42;/* jmp 0x1011da42 */
        l_0x1011_da72:
            ii(0x1011_da72, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_da75, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1011_da79, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_da7c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_da7f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_da81, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_da82, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_da83, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_da84, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_da85, 1);  ret();                                /* ret */
        }
    }
}
