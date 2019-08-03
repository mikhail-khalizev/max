using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("940bde1c-5449-4f17-8118-effc40850fec")]
        public void Method_1010_a36e()
        {
            ii(0x1010_a36e, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_a373, 5); calld(Definitions.sys_check_available_stack_size, 0x5b9da); /* call 0x10165d52 */
            ii(0x1010_a378, 1); pushd(esi);                             /* push esi */
            ii(0x1010_a379, 1); pushd(edi);                             /* push edi */
            ii(0x1010_a37a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_a37b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_a37d, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1010_a383, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_a386, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1010_a389, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1010_a38c, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
        l_0x1010_a38f:
            ii(0x1010_a38f, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1010_a392, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_a397, 2); if(jzd(0x1010_a3f6, 0x5d)) goto l_0x1010_a3f6; /* jz 0x1010a3f6 */
            ii(0x1010_a399, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_a39c, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_a39f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_a3a2, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_a3a7, 5); mov(edx, 0x101c_4e50);                  /* mov edx, 0x101c4e50 */
            ii(0x1010_a3ac, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_a3af, 5); calld(0x100d_4d78, -0x3563c);           /* call 0x100d4d78 */
            ii(0x1010_a3b4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_a3b6, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_a3ba, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_a3bd, 5); mov(edx, 0x101b_a5ac);                  /* mov edx, 0x101ba5ac */
            ii(0x1010_a3c2, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_a3c4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_a3c7, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_a3c9, 5); calld(0x1010_a2d7, -0xf7);              /* call 0x1010a2d7 */
            ii(0x1010_a3ce, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_a3d1, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1010_a3d5, 2); if(jnzd(0x1010_a3f4, 0x1d)) goto l_0x1010_a3f4; /* jnz 0x1010a3f4 */
            ii(0x1010_a3d7, 5); mov(ebx, 0xff);                         /* mov ebx, 0xff */
            ii(0x1010_a3dc, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_a3e0, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_a3e3, 5); mov(edx, 0x101b_a5ac);                  /* mov edx, 0x101ba5ac */
            ii(0x1010_a3e8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_a3ea, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_a3ed, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_a3ef, 5); calld(0x1010_89b0, -0x1a44);            /* call 0x101089b0 */
        l_0x1010_a3f4:
            ii(0x1010_a3f4, 2); jmpd(0x1010_a38f, -0x67); goto l_0x1010_a38f; /* jmp 0x1010a38f */
        l_0x1010_a3f6:
            ii(0x1010_a3f6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_a3f8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_a3f9, 1); popd(edi);                              /* pop edi */
            ii(0x1010_a3fa, 1); popd(esi);                              /* pop esi */
            ii(0x1010_a3fb, 1); retd(); return;                         /* ret */
        }
    }
}
