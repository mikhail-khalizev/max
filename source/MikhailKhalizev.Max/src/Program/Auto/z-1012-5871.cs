using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_5871-640fc662")]
        public void Method_1012_5871()
        {
            ii(0x1012_5871, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_5876, 5); call(Definitions.sys_check_available_stack_size, 0x4_04d7); /* call 0x10165d52 */
            ii(0x1012_587b, 1); push(ebx);                              /* push ebx */
            ii(0x1012_587c, 1); push(ecx);                              /* push ecx */
            ii(0x1012_587d, 1); push(edx);                              /* push edx */
            ii(0x1012_587e, 1); push(esi);                              /* push esi */
            ii(0x1012_587f, 1); push(edi);                              /* push edi */
            ii(0x1012_5880, 1); push(ebp);                              /* push ebp */
            ii(0x1012_5881, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_5883, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_5889, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x1012_588c, 7); mov(memd[ss, ebp - 0x8], 0x8);          /* mov dword [ebp-0x8], 0x8 */
            ii(0x1012_5893, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1012_5898, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_589a, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_58a1, 1); inc(edx);                               /* inc edx */
            ii(0x1012_58a2, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_58a3, 5); mov(eax, memd[ds, 0x101c_5878]);        /* mov eax, [0x101c5878] */
            ii(0x1012_58a8, 6); mov(edx, memd[ds, 0x101c_587c]);        /* mov edx, [0x101c587c] */
            ii(0x1012_58ae, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1012_58b0, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
        l_0x1012_58b2:
            ii(0x1012_58b2, 3); dec(memd[ss, ebp - 0x8]);               /* dec dword [ebp-0x8] */
            ii(0x1012_58b5, 5); cmp(memw[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1012_58ba, 2); if(jz(0x1012_58f2, 0x36)) goto l_0x1012_58f2; /* jz 0x101258f2 */
            ii(0x1012_58bc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_58be, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_58c5, 3); add(edx, 0x6);                          /* add edx, 0x6 */
            ii(0x1012_58c8, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_58ca, 1); inb(al, dx);                            /* in al, dx */
        l_0x1012_58cb:
            ii(0x1012_58cb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_58cd, 6); mov(ax, memw[ds, 0x101b_b45c]);         /* mov ax, [0x101bb45c] */
            ii(0x1012_58d3, 3); lea(edx, memd[ds, eax + 0x5]);          /* lea edx, [eax+0x5] */
            ii(0x1012_58d6, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_58d8, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_58d9, 3); and(eax, 0x60);                         /* and eax, 0x60 */
            ii(0x1012_58dc, 3); cmp(eax, 0x60);                         /* cmp eax, 0x60 */
            ii(0x1012_58df, 2); if(jnz(0x1012_58cb, -0x16)) goto l_0x1012_58cb; /* jnz 0x101258cb */
            ii(0x1012_58e1, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1012_58e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_58e8, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_58ef, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_58f0, 2); jmp(0x1012_58b2, -0x40); goto l_0x1012_58b2; /* jmp 0x101258b2 */
        l_0x1012_58f2:
            ii(0x1012_58f2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_58f4, 3); mov(dl, memb[ss, ebp - 0x4]);           /* mov dl, [ebp-0x4] */
            ii(0x1012_58f7, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1012_58fa, 5); mov(eax, memd[ds, 0x101c_587c]);        /* mov eax, [0x101c587c] */
            ii(0x1012_58ff, 6); mov(edx, memd[ds, edx + 0x101c_5880]);  /* mov edx, [edx+0x101c5880] */
            ii(0x1012_5905, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1012_5907, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1012_590c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_590e, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_5915, 1); inc(edx);                               /* inc edx */
            ii(0x1012_5916, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_5917, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_5919, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_591a, 1); pop(edi);                               /* pop edi */
            ii(0x1012_591b, 1); pop(esi);                               /* pop esi */
            ii(0x1012_591c, 1); pop(edx);                               /* pop edx */
            ii(0x1012_591d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_591e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_591f, 1); ret();                                  /* ret */
        }
    }
}
