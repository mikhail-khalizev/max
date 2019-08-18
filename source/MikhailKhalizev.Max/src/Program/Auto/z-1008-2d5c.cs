using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_2d5c-2ff66f7a")]
        public void Method_1008_2d5c()
        {
            ii(0x1008_2d5c, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1008_2d61, 5); calld(Definitions.sys_check_available_stack_size, 0xe_2fec); /* call 0x10165d52 */
            ii(0x1008_2d66, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_2d67, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_2d68, 1); pushd(esi);                             /* push esi */
            ii(0x1008_2d69, 1); pushd(edi);                             /* push edi */
            ii(0x1008_2d6a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_2d6b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_2d6d, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1008_2d73, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_2d76, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_2d79, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1008_2d7d, 2); if(jzd(0x1008_2d8e, 0xf)) goto l_0x1008_2d8e; /* jz 0x10082d8e */
            ii(0x1008_2d7f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2d82, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1008_2d85, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_2d8a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_2d8c, 2); if(jnzd(0x1008_2d94, 0x6)) goto l_0x1008_2d94; /* jnz 0x10082d94 */
        l_0x1008_2d8e:
            ii(0x1008_2d8e, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_2d92, 2); jmpd(0x1008_2dd7, 0x43); goto l_0x1008_2dd7; /* jmp 0x10082dd7 */
        l_0x1008_2d94:
            ii(0x1008_2d94, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2d97, 5); calld(0x1015_2aa9, 0xc_fd0d);           /* call 0x10152aa9 */
            ii(0x1008_2d9c, 3); sub(eax, 0x3);                          /* sub eax, 0x3 */
            ii(0x1008_2d9f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_2da2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_2da5, 4); imul(eax, memd_a32[ss, ebp - 0x10]);    /* imul eax, [ebp-0x10] */
            ii(0x1008_2da9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_2dac, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_2daf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_2db2, 5); calld(0x1007_5e64, -0xcf53);            /* call 0x10075e64 */
            ii(0x1008_2db7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2db9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2dbc, 5); calld(0x1007_0ca1, -0x1_2120);          /* call 0x10070ca1 */
            ii(0x1008_2dc1, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1008_2dc5, 2); if(jgd(0x1008_2dcd, 0x6)) goto l_0x1008_2dcd; /* jg 0x10082dcd */
            ii(0x1008_2dc7, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1008_2dcb, 2); jmpd(0x1008_2dd1, 0x4); goto l_0x1008_2dd1; /* jmp 0x10082dd1 */
        l_0x1008_2dcd:
            ii(0x1008_2dcd, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
        l_0x1008_2dd1:
            ii(0x1008_2dd1, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1008_2dd4, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x1008_2dd7:
            ii(0x1008_2dd7, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_2dda, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_2ddc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_2ddd, 1); popd(edi);                              /* pop edi */
            ii(0x1008_2dde, 1); popd(esi);                              /* pop esi */
            ii(0x1008_2ddf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_2de0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_2de1, 1); retd(); return;                         /* ret */
        }
    }
}
