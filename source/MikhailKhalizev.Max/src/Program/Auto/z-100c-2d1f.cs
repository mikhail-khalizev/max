using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("76432fb1-f2c2-4573-8626-9fd23a3e947c")]
        public void Method_100c_2d1f()
        {
            ii(0x100c_2d1f, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x100c_2d24, 5); calld(Definitions.sys_check_available_stack_size, 0xa_3029); /* call 0x10165d52 */
            ii(0x100c_2d29, 1); pushd(esi);                             /* push esi */
            ii(0x100c_2d2a, 1); pushd(edi);                             /* push edi */
            ii(0x100c_2d2b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_2d2c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_2d2e, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100c_2d34, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_2d37, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_2d3a, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x100c_2d3d, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100c_2d40, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x100c_2d44, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100c_2d48, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_2d4b, 5); calld(0x1007_6aac, -0x4_c2a4);          /* call 0x10076aac */
            ii(0x100c_2d50, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100c_2d55, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_2d58, 1); pushd(eax);                             /* push eax */
            ii(0x100c_2d59, 6); mov(ecx, memd_a32[ds, 0x101c_8170]);    /* mov ecx, [0x101c8170] */
            ii(0x100c_2d5f, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_2d62, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_2d64, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_2d66, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100c_2d69, 5); calld(0x1008_b148, -0x3_7c26);          /* call 0x1008b148 */
            ii(0x100c_2d6e, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100c_2d75, 2); jmpd(0x100c_2d7b, 0x4); goto l_0x100c_2d7b; /* jmp 0x100c2d7b */
        l_0x100c_2d77:
            ii(0x100c_2d77, 4); add(memd_a32[ss, ebp - 0x28], 0x2);     /* add dword [ebp-0x28], 0x2 */
        l_0x100c_2d7b:
            ii(0x100c_2d7b, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100c_2d7f, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_2d82, 6); if(jged(0x100c_2e39, 0xb1)) goto l_0x100c_2e39; /* jge 0x100c2e39 */
            ii(0x100c_2d88, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100c_2d8f, 2); jmpd(0x100c_2d97, 0x6); goto l_0x100c_2d97; /* jmp 0x100c2d97 */
        l_0x100c_2d91:
            ii(0x100c_2d91, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100c_2d94, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
        l_0x100c_2d97:
            ii(0x100c_2d97, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100c_2d9a, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100c_2d9e, 6); if(jged(0x100c_2e34, 0x90)) goto l_0x100c_2e34; /* jge 0x100c2e34 */
            ii(0x100c_2da4, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100c_2da8, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100c_2dab, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x100c_2db0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_2db2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_2db5, 5); calld(0x1008_b1a4, -0x3_7c16);          /* call 0x1008b1a4 */
            ii(0x100c_2dba, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100c_2dbd, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100c_2dc0, 5); calld(0x1010_82ce, 0x4_5509);           /* call 0x101082ce */
            ii(0x100c_2dc5, 2); test(al, al);                           /* test al, al */
            ii(0x100c_2dc7, 2); if(jzd(0x100c_2e2f, 0x66)) goto l_0x100c_2e2f; /* jz 0x100c2e2f */
            ii(0x100c_2dc9, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100c_2dcd, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100c_2dd0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_2dd3, 3); mov(eax, memd_a32[ds, eax + 0x67]);     /* mov eax, [eax+0x67] */
            ii(0x100c_2dd6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2dd8, 4); movsx(edx, memw_a32[ss, ebp - 0x12]);   /* movsx edx, word [ebp-0x12] */
            ii(0x100c_2ddc, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_2dde, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2de0, 4); movsx(ax, memb_a32[ds, eax]);           /* movsx ax, byte [eax] */
            ii(0x100c_2de4, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100c_2de7, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100c_2deb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_2ded, 2); if(jld(0x100c_2e2f, 0x40)) goto l_0x100c_2e2f; /* jl 0x100c2e2f */
            ii(0x100c_2def, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100c_2df3, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x100c_2df7, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_2df9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_2dfb, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x100c_2dff, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_2e02, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x100c_2e07, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_2e09, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_2e0c, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100c_2e0e, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x100c_2e12, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2e14, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_2e16, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100c_2e1a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_2e1d, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100c_2e20, 3); mov(edx, memd_a32[ds, edx + 0x67]);     /* mov edx, [edx+0x67] */
            ii(0x100c_2e23, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2e25, 4); movsx(edx, memw_a32[ss, ebp - 0x12]);   /* movsx edx, word [ebp-0x12] */
            ii(0x100c_2e29, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_2e2b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2e2d, 2); mov(memb_a32[ds, eax], bl);             /* mov [eax], bl */
        l_0x100c_2e2f:
            ii(0x100c_2e2f, 5); jmpd(0x100c_2d91, -0xa3); goto l_0x100c_2d91; /* jmp 0x100c2d91 */
        l_0x100c_2e34:
            ii(0x100c_2e34, 5); jmpd(0x100c_2d77, -0xc2); goto l_0x100c_2d77; /* jmp 0x100c2d77 */
        l_0x100c_2e39:
            ii(0x100c_2e39, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_2e3b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_2e3c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_2e3d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_2e3e, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}
