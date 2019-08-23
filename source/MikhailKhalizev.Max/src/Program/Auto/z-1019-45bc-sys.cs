using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_45bc-c9f71c6e")]
        public void /* sys */ Method_1019_45bc()
        {
            ii(0x1019_45bc, 1); pushd(edx);                             /* push edx */
            ii(0x1019_45bd, 1); pushd(esi);                             /* push esi */
            ii(0x1019_45be, 1); pushd(edi);                             /* push edi */
            ii(0x1019_45bf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_45c0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_45c2, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1019_45c8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1019_45cb, 4); mov(memw_a32[ss, ebp - 0x14], cx);      /* mov [ebp-0x14], cx */
            ii(0x1019_45cf, 3); mov(memd_a32[ss, ebp - 0x18], ebx);     /* mov [ebp-0x18], ebx */
            ii(0x1019_45d2, 4); imul(eax, memd_a32[ss, ebp - 0x8], 0x6); /* imul eax, [ebp-0x8], 0x6 */
            ii(0x1019_45d6, 7); cmp(memd_a32[ds, eax + 0x101c_0210], 0); /* cmp dword [eax+0x101c0210], 0x0 */
            ii(0x1019_45dd, 2); if(jnzd(0x1019_45f2, 0x13)) goto l_0x1019_45f2; /* jnz 0x101945f2 */
            ii(0x1019_45df, 8); cmp(memw_a32[ds, eax + 0x101c_0214], 0); /* cmp word [eax+0x101c0214], 0x0 */
            ii(0x1019_45e7, 2); if(jnzd(0x1019_45f2, 0x9)) goto l_0x1019_45f2; /* jnz 0x101945f2 */
            ii(0x1019_45e9, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
            ii(0x1019_45f0, 2); jmpd(0x1019_4661, 0x6f); goto l_0x1019_4661; /* jmp 0x10194661 */
        l_0x1019_45f2:
            ii(0x1019_45f2, 4); imul(edx, memd_a32[ss, ebp - 0x8], 0x6); /* imul edx, [ebp-0x8], 0x6 */
            ii(0x1019_45f6, 7); mov(ax, memw_a32[ds, edx + 0x101c_0214]); /* mov ax, [edx+0x101c0214] */
            ii(0x1019_45fd, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x1019_4601, 6); mov(eax, memd_a32[ds, edx + 0x101c_0210]); /* mov eax, [edx+0x101c0210] */
            ii(0x1019_4607, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1019_460a, 4); imul(edx, memd_a32[ss, ebp - 0x8], 0x6); /* imul edx, [ebp-0x8], 0x6 */
            ii(0x1019_460e, 7); mov(ax, memw_a32[ds, edx + 0x101c_0232]); /* mov ax, [edx+0x101c0232] */
            ii(0x1019_4615, 4); mov(memw_a32[ss, ebp - 0xc], ax);       /* mov [ebp-0xc], ax */
            ii(0x1019_4619, 6); mov(eax, memd_a32[ds, edx + 0x101c_022e]); /* mov eax, [edx+0x101c022e] */
            ii(0x1019_461f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1019_4622, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1019_4626, 2); if(jnzd(0x1019_462f, 0x7)) goto l_0x1019_462f; /* jnz 0x1019462f */
            ii(0x1019_4628, 5); cmp(memw_a32[ss, ebp - 0x14], 0);       /* cmp word [ebp-0x14], 0x0 */
            ii(0x1019_462d, 2); if(jzd(0x1019_4651, 0x22)) goto l_0x1019_4651; /* jz 0x10194651 */
        l_0x1019_462f:
            ii(0x1019_462f, 4); movzx(eax, memw_a32[ss, ebp - 0x14]);   /* movzx eax, word [ebp-0x14] */
            ii(0x1019_4633, 1); pushd(eax);                             /* push eax */
            ii(0x1019_4634, 3); pushd(memd_a32[ss, ebp - 0x18]);        /* push dword [ebp-0x18] */
            ii(0x1019_4637, 4); movzx(eax, memw_a32[ss, ebp - 0x1c]);   /* movzx eax, word [ebp-0x1c] */
            ii(0x1019_463b, 1); pushd(eax);                             /* push eax */
            ii(0x1019_463c, 3); pushd(memd_a32[ss, ebp - 0x20]);        /* push dword [ebp-0x20] */
            ii(0x1019_463f, 4); movzx(eax, memw_a32[ss, ebp - 0xc]);    /* movzx eax, word [ebp-0xc] */
            ii(0x1019_4643, 1); pushd(eax);                             /* push eax */
            ii(0x1019_4644, 3); pushd(memd_a32[ss, ebp - 0x10]);        /* push dword [ebp-0x10] */
            ii(0x1019_4647, 5); calld(/* sys */ 0x1019_4e9d, 0x851);    /* call 0x10194e9d */
            ii(0x1019_464c, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1019_464f, 2); jmpd(0x1019_465a, 0x9); goto l_0x1019_465a; /* jmp 0x1019465a */
        l_0x1019_4651:
            ii(0x1019_4651, 7); mov(memd_a32[ss, ebp - 0x4], 0x2);      /* mov dword [ebp-0x4], 0x2 */
            ii(0x1019_4658, 2); jmpd(0x1019_4661, 0x7); goto l_0x1019_4661; /* jmp 0x10194661 */
        l_0x1019_465a:
            ii(0x1019_465a, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1019_4661:
            ii(0x1019_4661, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_4664, 1); leaved();                               /* leave */
            ii(0x1019_4665, 1); popd(edi);                              /* pop edi */
            ii(0x1019_4666, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4667, 1); popd(edx);                              /* pop edx */
            ii(0x1019_4668, 1); retd();                                 /* ret */
        }
    }
}
