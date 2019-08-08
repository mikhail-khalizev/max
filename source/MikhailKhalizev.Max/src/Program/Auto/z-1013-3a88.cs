using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("88cad50d-4103-402d-89b1-fa146c039f6a")]
        public void Method_1013_3a88()
        {
            ii(0x1013_3a88, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1013_3a8d, 5); calld(Definitions.sys_check_available_stack_size, 0x3_22c0); /* call 0x10165d52 */
            ii(0x1013_3a92, 1); pushd(esi);                             /* push esi */
            ii(0x1013_3a93, 1); pushd(edi);                             /* push edi */
            ii(0x1013_3a94, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_3a95, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3a97, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1013_3a9d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_3aa0, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1013_3aa3, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1013_3aa6, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1013_3aa9, 7); mov(memd_a32[ss, ebp - 0x18], 0x7fff_ffff); /* mov dword [ebp-0x18], 0x7fffffff */
            ii(0x1013_3ab0, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1013_3ab7, 2); jmpd(0x1013_3abd, 0x4); goto l_0x1013_3abd; /* jmp 0x10133abd */
        l_0x1013_3ab9:
            ii(0x1013_3ab9, 4); add(memd_a32[ss, ebp - 0x1c], 0x3);     /* add dword [ebp-0x1c], 0x3 */
        l_0x1013_3abd:
            ii(0x1013_3abd, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3ac1, 5); cmp(eax, 0x300);                        /* cmp eax, 0x300 */
            ii(0x1013_3ac6, 6); if(jged(0x1013_3bb6, 0xea)) goto l_0x1013_3bb6; /* jge 0x10133bb6 */
            ii(0x1013_3acc, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_3ad0, 2); if(jnzd(0x1013_3b08, 0x36)) goto l_0x1013_3b08; /* jnz 0x10133b08 */
            ii(0x1013_3ad2, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3ad6, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1013_3ad9, 2); if(jld(0x1013_3ae4, 0x9)) goto l_0x1013_3ae4; /* jl 0x10133ae4 */
            ii(0x1013_3adb, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3adf, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x1013_3ae2, 2); if(jled(0x1013_3ae6, 0x2)) goto l_0x1013_3ae6; /* jle 0x10133ae6 */
        l_0x1013_3ae4:
            ii(0x1013_3ae4, 2); jmpd(0x1013_3aeb, 0x5); goto l_0x1013_3aeb; /* jmp 0x10133aeb */
        l_0x1013_3ae6:
            ii(0x1013_3ae6, 5); jmpd(0x1013_3bb1, 0xc6); goto l_0x1013_3bb1; /* jmp 0x10133bb1 */
        l_0x1013_3aeb:
            ii(0x1013_3aeb, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3aef, 5); cmp(eax, 0x120);                        /* cmp eax, 0x120 */
            ii(0x1013_3af4, 2); if(jld(0x1013_3b01, 0xb)) goto l_0x1013_3b01; /* jl 0x10133b01 */
            ii(0x1013_3af6, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3afa, 5); cmp(eax, 0x17d);                        /* cmp eax, 0x17d */
            ii(0x1013_3aff, 2); if(jled(0x1013_3b03, 0x2)) goto l_0x1013_3b03; /* jle 0x10133b03 */
        l_0x1013_3b01:
            ii(0x1013_3b01, 2); jmpd(0x1013_3b08, 0x5); goto l_0x1013_3b08; /* jmp 0x10133b08 */
        l_0x1013_3b03:
            ii(0x1013_3b03, 5); jmpd(0x1013_3bb1, 0xa9); goto l_0x1013_3bb1; /* jmp 0x10133bb1 */
        l_0x1013_3b08:
            ii(0x1013_3b08, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_3b0c, 5); mov(eax, memd_a32[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x1013_3b11, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_3b13, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1013_3b15, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_3b1a, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1013_3b1d, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1013_3b21, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1013_3b24, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_3b26, 3); mov(memd_a32[ss, ebp - 0x24], edx);     /* mov [ebp-0x24], edx */
            ii(0x1013_3b29, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3b2d, 6); mov(edx, memd_a32[ds, Definitions.ptr_to_pallete]); /* mov edx, [0x101c9464] */
            ii(0x1013_3b33, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_3b35, 3); mov(al, memb_a32[ds, eax + 0x1]);       /* mov al, [eax+0x1] */
            ii(0x1013_3b38, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_3b3d, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1013_3b40, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_3b44, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1013_3b47, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_3b49, 3); mov(memd_a32[ss, ebp - 0x28], edx);     /* mov [ebp-0x28], edx */
            ii(0x1013_3b4c, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_3b50, 5); mov(eax, memd_a32[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x1013_3b55, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_3b57, 3); mov(al, memb_a32[ds, eax + 0x2]);       /* mov al, [eax+0x2] */
            ii(0x1013_3b5a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_3b5f, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1013_3b62, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_3b66, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1013_3b69, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_3b6b, 3); mov(memd_a32[ss, ebp - 0x2c], edx);     /* mov [ebp-0x2c], edx */
            ii(0x1013_3b6e, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x1013_3b71, 4); imul(edx, memd_a32[ss, ebp - 0x24]);    /* imul edx, [ebp-0x24] */
            ii(0x1013_3b75, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1013_3b78, 4); imul(eax, memd_a32[ss, ebp - 0x28]);    /* imul eax, [ebp-0x28] */
            ii(0x1013_3b7c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_3b7e, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1013_3b81, 4); imul(eax, memd_a32[ss, ebp - 0x2c]);    /* imul eax, [ebp-0x2c] */
            ii(0x1013_3b85, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_3b87, 3); mov(memd_a32[ss, ebp - 0x30], edx);     /* mov [ebp-0x30], edx */
            ii(0x1013_3b8a, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1013_3b8d, 3); cmp(eax, memd_a32[ss, ebp - 0x18]);     /* cmp eax, [ebp-0x18] */
            ii(0x1013_3b90, 2); if(jged(0x1013_3bb1, 0x1f)) goto l_0x1013_3bb1; /* jge 0x10133bb1 */
            ii(0x1013_3b92, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1013_3b95, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_3b98, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_3b9c, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1013_3ba1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_3ba3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_3ba6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_3ba8, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1013_3bab, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1013_3baf, 2); if(jzd(0x1013_3bb6, 0x5)) goto l_0x1013_3bb6; /* jz 0x10133bb6 */
        l_0x1013_3bb1:
            ii(0x1013_3bb1, 5); jmpd(0x1013_3ab9, -0xfd); goto l_0x1013_3ab9; /* jmp 0x10133ab9 */
        l_0x1013_3bb6:
            ii(0x1013_3bb6, 3); mov(al, memb_a32[ss, ebp - 0x34]);      /* mov al, [ebp-0x34] */
            ii(0x1013_3bb9, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1013_3bbc, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1013_3bbf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3bc1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_3bc2, 1); popd(edi);                              /* pop edi */
            ii(0x1013_3bc3, 1); popd(esi);                              /* pop esi */
            ii(0x1013_3bc4, 1); retd(); return;                         /* ret */
        }
    }
}
