using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9ae0-d219a27f")]
        public void Method_100a_9ae0()
        {
            ii(0x100a_9ae0, 5); push(0x30);                             /* push 0x30 */
            ii(0x100a_9ae5, 5); call(Definitions.sys_check_available_stack_size, 0xb_c268); /* call 0x10165d52 */
            ii(0x100a_9aea, 1); push(ebx);                              /* push ebx */
            ii(0x100a_9aeb, 1); push(ecx);                              /* push ecx */
            ii(0x100a_9aec, 1); push(edx);                              /* push edx */
            ii(0x100a_9aed, 1); push(esi);                              /* push esi */
            ii(0x100a_9aee, 1); push(edi);                              /* push edi */
            ii(0x100a_9aef, 1); push(ebp);                              /* push ebp */
            ii(0x100a_9af0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9af2, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_9af8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
        l_0x100a_9afb:
            ii(0x100a_9afb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9afe, 5); call(0x100a_99aa, -0x159);              /* call 0x100a99aa */
            ii(0x100a_9b03, 2); test(al, al);                           /* test al, al */
            ii(0x100a_9b05, 2); if(jnz(0x100a_9b10, 9)) goto l_0x100a_9b10; /* jnz 0x100a9b10 */
            ii(0x100a_9b07, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_9b0b, 5); jmp(0x100a_9c27, 0x117); goto l_0x100a_9c27; /* jmp 0x100a9c27 */
        l_0x100a_9b10:
            ii(0x100a_9b10, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9b13, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x100a_9b16, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9b19, 4); mov(dx, memw[ds, edx + 26]);            /* mov dx, [edx+0x1a] */
            ii(0x100a_9b1d, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
            ii(0x100a_9b20, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9b23, 3); mov(ebx, memd[ds, eax + 18]);           /* mov ebx, [eax+0x12] */
            ii(0x100a_9b26, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9b29, 3); mov(edx, memd[ds, eax + 18]);           /* mov edx, [eax+0x12] */
            ii(0x100a_9b2c, 3); mov(ax, memw[ds, ebx]);                 /* mov ax, [ebx] */
            ii(0x100a_9b2f, 4); imul(ax, memw[ds, edx]);                /* imul ax, [edx] */
            ii(0x100a_9b33, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_9b35, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9b38, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x100a_9b3c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100a_9b3e, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100a_9b41, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_9b44, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9b47, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x100a_9b4a, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x100a_9b4d, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100a_9b50, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9b53, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x100a_9b56, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100a_9b59, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100a_9b5c, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_9b5f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9b62, 4); mov(dx, memw[ds, eax + 28]);            /* mov dx, [eax+0x1c] */
            ii(0x100a_9b66, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100a_9b69, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9b6c, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x100a_9b6f, 4); imul(dx, memw[ds, eax]);                /* imul dx, [eax] */
            ii(0x100a_9b73, 3); add(edx, memd[ss, ebp - 16]);           /* add edx, [ebp-0x10] */
            ii(0x100a_9b76, 1); inc(edx);                               /* inc edx */
            ii(0x100a_9b77, 3); mov(memd[ss, ebp - 20], edx);           /* mov [ebp-0x14], edx */
            ii(0x100a_9b7a, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_9b7d, 4); cmp(ax, memw[ss, ebp - 16]);            /* cmp ax, [ebp-0x10] */
            ii(0x100a_9b81, 2); if(jle(0x100a_9b9e, 0x1b)) goto l_0x100a_9b9e; /* jle 0x100a9b9e */
            ii(0x100a_9b83, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_9b86, 4); cmp(ax, memw[ss, ebp - 20]);            /* cmp ax, [ebp-0x14] */
            ii(0x100a_9b8a, 2); if(jle(0x100a_9b9c, 0x10)) goto l_0x100a_9b9c; /* jle 0x100a9b9c */
            ii(0x100a_9b8c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9b8f, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x100a_9b92, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9b95, 4); mov(dx, memw[ds, edx + 28]);            /* mov dx, [edx+0x1c] */
            ii(0x100a_9b99, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
        l_0x100a_9b9c:
            ii(0x100a_9b9c, 2); jmp(0x100a_9bb7, 0x19); goto l_0x100a_9bb7; /* jmp 0x100a9bb7 */
        l_0x100a_9b9e:
            ii(0x100a_9b9e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_9ba1, 4); cmp(ax, memw[ss, ebp - 20]);            /* cmp ax, [ebp-0x14] */
            ii(0x100a_9ba5, 2); if(jg(0x100a_9bb7, 0x10)) goto l_0x100a_9bb7; /* jg 0x100a9bb7 */
            ii(0x100a_9ba7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9baa, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x100a_9bad, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9bb0, 4); mov(dx, memw[ds, edx + 28]);            /* mov dx, [edx+0x1c] */
            ii(0x100a_9bb4, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
        l_0x100a_9bb7:
            ii(0x100a_9bb7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9bba, 4); mov(ax, memw[ds, eax + 10]);            /* mov ax, [eax+0xa] */
            ii(0x100a_9bbe, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9bc1, 3); add(ax, memw[ds, edx]);                 /* add ax, [edx] */
            ii(0x100a_9bc4, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9bc7, 4); mov(memw[ds, edx + 14], ax);            /* mov [edx+0xe], ax */
            ii(0x100a_9bcb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9bce, 4); mov(ax, memw[ds, eax + 12]);            /* mov ax, [eax+0xc] */
            ii(0x100a_9bd2, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9bd5, 4); add(ax, memw[ds, edx + 2]);             /* add ax, [edx+0x2] */
            ii(0x100a_9bd9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9bdc, 4); mov(memw[ds, edx + 16], ax);            /* mov [edx+0x10], ax */
            ii(0x100a_9be0, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9be3, 3); mov(eax, memd[ds, edx + 12]);           /* mov eax, [edx+0xc] */
            ii(0x100a_9be6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_9be9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_9beb, 2); if(jl(0x100a_9bfd, 0x10)) goto l_0x100a_9bfd; /* jl 0x100a9bfd */
            ii(0x100a_9bed, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9bf0, 4); mov(ax, memw[ds, eax + 14]);            /* mov ax, [eax+0xe] */
            ii(0x100a_9bf4, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100a_9bfb, 2); if(jl(0x100a_9bff, 2)) goto l_0x100a_9bff; /* jl 0x100a9bff */
        l_0x100a_9bfd:
            ii(0x100a_9bfd, 2); jmp(0x100a_9c0c, 0xd); goto l_0x100a_9c0c; /* jmp 0x100a9c0c */
        l_0x100a_9bff:
            ii(0x100a_9bff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9c02, 3); mov(eax, memd[ds, eax + 14]);           /* mov eax, [eax+0xe] */
            ii(0x100a_9c05, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_9c08, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_9c0a, 2); if(jge(0x100a_9c0e, 2)) goto l_0x100a_9c0e; /* jge 0x100a9c0e */
        l_0x100a_9c0c:
            ii(0x100a_9c0c, 2); jmp(0x100a_9c1e, 0x10); goto l_0x100a_9c1e; /* jmp 0x100a9c1e */
        l_0x100a_9c0e:
            ii(0x100a_9c0e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9c11, 4); mov(ax, memw[ds, eax + 16]);            /* mov ax, [eax+0x10] */
            ii(0x100a_9c15, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100a_9c1c, 2); if(jl(0x100a_9c23, 5)) goto l_0x100a_9c23; /* jl 0x100a9c23 */
        l_0x100a_9c1e:
            ii(0x100a_9c1e, 5); jmp(0x100a_9afb, -0x128); goto l_0x100a_9afb; /* jmp 0x100a9afb */
        l_0x100a_9c23:
            ii(0x100a_9c23, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
        l_0x100a_9c27:
            ii(0x100a_9c27, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100a_9c2a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9c2c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_9c2d, 1); pop(edi);                               /* pop edi */
            ii(0x100a_9c2e, 1); pop(esi);                               /* pop esi */
            ii(0x100a_9c2f, 1); pop(edx);                               /* pop edx */
            ii(0x100a_9c30, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_9c31, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_9c32, 1); ret();                                  /* ret */
        }
    }
}
