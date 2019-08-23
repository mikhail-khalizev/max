using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_894c-1cd7f611")]
        public void Method_1012_894c()
        {
            ii(0x1012_894c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_8951, 5); call(Definitions.sys_check_available_stack_size, 0x3_d3fc); /* call 0x10165d52 */
            ii(0x1012_8956, 1); push(ebx);                              /* push ebx */
            ii(0x1012_8957, 1); push(ecx);                              /* push ecx */
            ii(0x1012_8958, 1); push(edx);                              /* push edx */
            ii(0x1012_8959, 1); push(esi);                              /* push esi */
            ii(0x1012_895a, 1); push(edi);                              /* push edi */
            ii(0x1012_895b, 1); push(ebp);                              /* push ebp */
            ii(0x1012_895c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_895e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_8964, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_8967, 7); mov(memd[ss, ebp - 0x8], 0x101c_5c21);  /* mov dword [ebp-0x8], 0x101c5c21 */
            ii(0x1012_896e, 7); mov(memb[ds, 0x101c_5c1c], 0x9);        /* mov byte [0x101c5c1c], 0x9 */
            ii(0x1012_8975, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_8978, 6); mov(memw[ds, 0x101c_5c1d], ax);         /* mov [0x101c5c1d], ax */
            ii(0x1012_897e, 9); mov(memw[ds, 0x101c_5c1f], 0xaa);       /* mov word [0x101c5c1f], 0xaa */
            ii(0x1012_8987, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1012_898b, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_8991, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1012_8997, 5); call(0x100c_b67c, -0x5_d320);           /* call 0x100cb67c */
            ii(0x1012_899c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_899e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_89a1, 3); mov(memw[ds, eax], bx);                 /* mov [eax], bx */
            ii(0x1012_89a4, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1012_89a8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_89ae, 7); mov(ax, memw[ds, eax + 0x101c_a583]);   /* mov ax, [eax+0x101ca583] */
            ii(0x1012_89b5, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_89b8, 4); mov(memw[ds, edx + 0x2], ax);           /* mov [edx+0x2], ax */
            ii(0x1012_89bc, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x1012_89c1, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1012_89c5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_89cb, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1012_89d0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_89d2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_89d5, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1012_89d8, 5); call(Definitions.sys_memcpy, 0x3_d46e); /* call 0x10165e4b */
            ii(0x1012_89dd, 5); mov(ebx, 0x60);                         /* mov ebx, 0x60 */
            ii(0x1012_89e2, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1012_89e6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_89ec, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1012_89f1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_89f3, 6); lea(edx, memd[ds, eax + 0x88]);         /* lea edx, [eax+0x88] */
            ii(0x1012_89f9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_89fc, 3); add(eax, 0x4a);                         /* add eax, 0x4a */
            ii(0x1012_89ff, 5); call(Definitions.sys_memcpy, 0x3_d447); /* call 0x10165e4b */
            ii(0x1012_8a04, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1012_8a09, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1012_8a0c, 3); add(ebx, 0x2c);                         /* add ebx, 0x2c */
            ii(0x1012_8a0f, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_8a12, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1012_8a14, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x1012_8a17, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1012_8a1c, 5); call(0x1010_6281, -0x2_27a0);           /* call 0x10106281 */
            ii(0x1012_8a21, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_8a26, 5); call(0x1012_5be9, -0x2e42);             /* call 0x10125be9 */
            ii(0x1012_8a2b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_8a2d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_8a2e, 1); pop(edi);                               /* pop edi */
            ii(0x1012_8a2f, 1); pop(esi);                               /* pop esi */
            ii(0x1012_8a30, 1); pop(edx);                               /* pop edx */
            ii(0x1012_8a31, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_8a32, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_8a33, 1); ret();                                  /* ret */
        }
    }
}
