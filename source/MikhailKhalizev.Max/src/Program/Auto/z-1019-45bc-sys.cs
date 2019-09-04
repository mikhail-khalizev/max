using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_45bc-c9f71c6e")]
        public void /* sys */ Method_1019_45bc()
        {
            ii(0x1019_45bc, 1); push(edx);                              /* push edx */
            ii(0x1019_45bd, 1); push(esi);                              /* push esi */
            ii(0x1019_45be, 1); push(edi);                              /* push edi */
            ii(0x1019_45bf, 1); push(ebp);                              /* push ebp */
            ii(0x1019_45c0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_45c2, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1019_45c8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1019_45cb, 4); mov(memw[ss, ebp - 20], cx);            /* mov [ebp-0x14], cx */
            ii(0x1019_45cf, 3); mov(memd[ss, ebp - 24], ebx);           /* mov [ebp-0x18], ebx */
            ii(0x1019_45d2, 4); imul(eax, memd[ss, ebp - 8], 6);        /* imul eax, [ebp-0x8], 0x6 */
            ii(0x1019_45d6, 7); cmp(memd[ds, eax + 0x101c_0210], 0);    /* cmp dword [eax+0x101c0210], 0x0 */
            ii(0x1019_45dd, 2); if(jnz(0x1019_45f2, 0x13)) goto l_0x1019_45f2; /* jnz 0x101945f2 */
            ii(0x1019_45df, 8); cmp(memw[ds, eax + 0x101c_0214], 0);    /* cmp word [eax+0x101c0214], 0x0 */
            ii(0x1019_45e7, 2); if(jnz(0x1019_45f2, 9)) goto l_0x1019_45f2; /* jnz 0x101945f2 */
            ii(0x1019_45e9, 7); mov(memd[ss, ebp - 4], 1);              /* mov dword [ebp-0x4], 0x1 */
            ii(0x1019_45f0, 2); jmp(0x1019_4661, 0x6f); goto l_0x1019_4661; /* jmp 0x10194661 */
        l_0x1019_45f2:
            ii(0x1019_45f2, 4); imul(edx, memd[ss, ebp - 8], 6);        /* imul edx, [ebp-0x8], 0x6 */
            ii(0x1019_45f6, 7); mov(ax, memw[ds, edx + 0x101c_0214]);   /* mov ax, [edx+0x101c0214] */
            ii(0x1019_45fd, 4); mov(memw[ss, ebp - 28], ax);            /* mov [ebp-0x1c], ax */
            ii(0x1019_4601, 6); mov(eax, memd[ds, edx + 0x101c_0210]);  /* mov eax, [edx+0x101c0210] */
            ii(0x1019_4607, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1019_460a, 4); imul(edx, memd[ss, ebp - 8], 6);        /* imul edx, [ebp-0x8], 0x6 */
            ii(0x1019_460e, 7); mov(ax, memw[ds, edx + 0x101c_0232]);   /* mov ax, [edx+0x101c0232] */
            ii(0x1019_4615, 4); mov(memw[ss, ebp - 12], ax);            /* mov [ebp-0xc], ax */
            ii(0x1019_4619, 6); mov(eax, memd[ds, edx + 0x101c_022e]);  /* mov eax, [edx+0x101c022e] */
            ii(0x1019_461f, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1019_4622, 4); cmp(memd[ss, ebp - 24], 0);             /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1019_4626, 2); if(jnz(0x1019_462f, 7)) goto l_0x1019_462f; /* jnz 0x1019462f */
            ii(0x1019_4628, 5); cmp(memw[ss, ebp - 20], 0);             /* cmp word [ebp-0x14], 0x0 */
            ii(0x1019_462d, 2); if(jz(0x1019_4651, 0x22)) goto l_0x1019_4651; /* jz 0x10194651 */
        l_0x1019_462f:
            ii(0x1019_462f, 4); movzx(eax, memw[ss, ebp - 20]);         /* movzx eax, word [ebp-0x14] */
            ii(0x1019_4633, 1); push(eax);                              /* push eax */
            ii(0x1019_4634, 3); push(memd[ss, ebp - 24]);               /* push dword [ebp-0x18] */
            ii(0x1019_4637, 4); movzx(eax, memw[ss, ebp - 28]);         /* movzx eax, word [ebp-0x1c] */
            ii(0x1019_463b, 1); push(eax);                              /* push eax */
            ii(0x1019_463c, 3); push(memd[ss, ebp - 32]);               /* push dword [ebp-0x20] */
            ii(0x1019_463f, 4); movzx(eax, memw[ss, ebp - 12]);         /* movzx eax, word [ebp-0xc] */
            ii(0x1019_4643, 1); push(eax);                              /* push eax */
            ii(0x1019_4644, 3); push(memd[ss, ebp - 16]);               /* push dword [ebp-0x10] */
            ii(0x1019_4647, 5); call(/* sys */ 0x1019_4e9d, 0x851);     /* call 0x10194e9d */
            ii(0x1019_464c, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1019_464f, 2); jmp(0x1019_465a, 9); goto l_0x1019_465a; /* jmp 0x1019465a */
        l_0x1019_4651:
            ii(0x1019_4651, 7); mov(memd[ss, ebp - 4], 2);              /* mov dword [ebp-0x4], 0x2 */
            ii(0x1019_4658, 2); jmp(0x1019_4661, 7); goto l_0x1019_4661; /* jmp 0x10194661 */
        l_0x1019_465a:
            ii(0x1019_465a, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
        l_0x1019_4661:
            ii(0x1019_4661, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1019_4664, 1); leave();                                /* leave */
            ii(0x1019_4665, 1); pop(edi);                               /* pop edi */
            ii(0x1019_4666, 1); pop(esi);                               /* pop esi */
            ii(0x1019_4667, 1); pop(edx);                               /* pop edx */
            ii(0x1019_4668, 1); ret();                                  /* ret */
        }
    }
}
