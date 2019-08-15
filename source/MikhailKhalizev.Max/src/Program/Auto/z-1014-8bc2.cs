using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0f2cc88b-17f7-418c-accf-205efcddaf0d")]
        public void Method_1014_8bc2()
        {
            ii(0x1014_8bc2, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1014_8bc7, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d186); /* call 0x10165d52 */
            ii(0x1014_8bcc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_8bcd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_8bce, 1); pushd(esi);                             /* push esi */
            ii(0x1014_8bcf, 1); pushd(edi);                             /* push edi */
            ii(0x1014_8bd0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_8bd1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8bd3, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1014_8bd9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8bdc, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_8bdf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8be2, 5); calld(0x1014_4ef4, -0x3cf3);            /* call 0x10144ef4 */
            ii(0x1014_8be7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8bea, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_8bed, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_8bf0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8bf3, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_8bf6, 5); calld(0x1012_0d24, -0x2_7ed7);          /* call 0x10120d24 */
            ii(0x1014_8bfb, 3); sub(eax, 0x65);                         /* sub eax, 0x65 */
            ii(0x1014_8bfe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8c01, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_8c04, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1014_8c07, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8c0a, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_8c0d, 5); calld(Definitions.my_ctor_0x101b_38d0, -0xd_23ce); /* call 0x10076844 */
            ii(0x1014_8c12, 3); sub(eax, 0x6c);                         /* sub eax, 0x6c */
            ii(0x1014_8c15, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8c18, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_8c1b, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1014_8c1e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8c21, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_8c24, 5); calld(0x1007_6998, -0xd_2291);          /* call 0x10076998 */
            ii(0x1014_8c29, 3); sub(eax, 0x70);                         /* sub eax, 0x70 */
            ii(0x1014_8c2c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8c2f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_8c32, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1014_8c35, 5); calld(0x1008_b3ec, -0xb_d84e);          /* call 0x1008b3ec */
            ii(0x1014_8c3a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_8c3d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8c40, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_8c43, 5); calld(0x1008_b1e4, -0xb_da64);          /* call 0x1008b1e4 */
            ii(0x1014_8c48, 3); sub(eax, 0x74);                         /* sub eax, 0x74 */
            ii(0x1014_8c4b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8c4e, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_8c51, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1014_8c54, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8c57, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_8c5c, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xd_2571); /* call 0x100766f0 */
            ii(0x1014_8c61, 5); sub(eax, 0x82);                         /* sub eax, 0x82 */
            ii(0x1014_8c66, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8c69, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_8c6c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_8c6f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8c72, 5); add(eax, 0x86);                         /* add eax, 0x86 */
            ii(0x1014_8c77, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xd_258c); /* call 0x100766f0 */
            ii(0x1014_8c7c, 5); sub(eax, 0x86);                         /* sub eax, 0x86 */
            ii(0x1014_8c81, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8c84, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_8c87, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_8c8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8c8d, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1014_8c92, 5); calld(0x1009_ca70, -0xa_c227);          /* call 0x1009ca70 */
            ii(0x1014_8c97, 5); sub(eax, 0x8a);                         /* sub eax, 0x8a */
            ii(0x1014_8c9c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8c9f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_8ca2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_8ca5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8ca8, 5); add(eax, 0x94);                         /* add eax, 0x94 */
            ii(0x1014_8cad, 5); calld(0x1009_ca70, -0xa_c242);          /* call 0x1009ca70 */
            ii(0x1014_8cb2, 5); sub(eax, 0x94);                         /* sub eax, 0x94 */
            ii(0x1014_8cb7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8cba, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_8cbd, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_8cc0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8cc3, 5); add(eax, 0x9f);                         /* add eax, 0x9f */
            ii(0x1014_8cc8, 5); calld(Definitions.my_ctor_0x101b_4184, -0xd_21dd); /* call 0x10076af0 */
            ii(0x1014_8ccd, 5); sub(eax, 0x9f);                         /* sub eax, 0x9f */
            ii(0x1014_8cd2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8cd5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8cd8, 5); add(eax, 0xd9);                         /* add eax, 0xd9 */
            ii(0x1014_8cdd, 5); calld(Definitions.my_ctor_0x101b_4184, -0xd_21f2); /* call 0x10076af0 */
            ii(0x1014_8ce2, 5); sub(eax, 0xd9);                         /* sub eax, 0xd9 */
            ii(0x1014_8ce7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8cea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8ced, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_7398); /* mov dword [eax+0x2], 0x101b7398 */
            ii(0x1014_8cf4, 7); inc(memw_a32[ds, 0x101c_8148]);         /* inc word [0x101c8148] */
            ii(0x1014_8cfb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8cfe, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1014_8d02, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d05, 4); mov(memw_a32[ds, edx + 0x8], ax);       /* mov [edx+0x8], ax */
            ii(0x1014_8d09, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d0c, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1014_8d0f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d12, 3); mov(memd_a32[ds, edx + 0xa], eax);      /* mov [edx+0xa], eax */
            ii(0x1014_8d15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d18, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1014_8d1b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d1e, 3); mov(memd_a32[ds, edx + 0xe], eax);      /* mov [edx+0xe], eax */
            ii(0x1014_8d21, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d24, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1014_8d27, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d2a, 3); mov(memd_a32[ds, edx + 0x12], eax);     /* mov [edx+0x12], eax */
            ii(0x1014_8d2d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d30, 4); mov(ax, memw_a32[ds, eax + 0x16]);      /* mov ax, [eax+0x16] */
            ii(0x1014_8d34, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d37, 4); mov(memw_a32[ds, edx + 0x16], ax);      /* mov [edx+0x16], ax */
            ii(0x1014_8d3b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d3e, 4); mov(ax, memw_a32[ds, eax + 0x18]);      /* mov ax, [eax+0x18] */
            ii(0x1014_8d42, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d45, 4); mov(memw_a32[ds, edx + 0x18], ax);      /* mov [edx+0x18], ax */
            ii(0x1014_8d49, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d4c, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1014_8d50, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d53, 4); mov(memw_a32[ds, edx + 0x1a], ax);      /* mov [edx+0x1a], ax */
            ii(0x1014_8d57, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d5a, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1014_8d5e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d61, 4); mov(memw_a32[ds, edx + 0x1c], ax);      /* mov [edx+0x1c], ax */
            ii(0x1014_8d65, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d68, 4); mov(ax, memw_a32[ds, eax + 0x1e]);      /* mov ax, [eax+0x1e] */
            ii(0x1014_8d6c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d6f, 4); mov(memw_a32[ds, edx + 0x1e], ax);      /* mov [edx+0x1e], ax */
            ii(0x1014_8d73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d76, 4); mov(ax, memw_a32[ds, eax + 0x20]);      /* mov ax, [eax+0x20] */
            ii(0x1014_8d7a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d7d, 4); mov(memw_a32[ds, edx + 0x20], ax);      /* mov [edx+0x20], ax */
            ii(0x1014_8d81, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d84, 3); mov(eax, memd_a32[ds, eax + 0x22]);     /* mov eax, [eax+0x22] */
            ii(0x1014_8d87, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d8a, 3); mov(memd_a32[ds, edx + 0x22], eax);     /* mov [edx+0x22], eax */
            ii(0x1014_8d8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d90, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_8d93, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8d96, 3); mov(memb_a32[ds, edx + 0x26], al);      /* mov [edx+0x26], al */
            ii(0x1014_8d99, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8d9c, 3); mov(al, memb_a32[ds, eax + 0x27]);      /* mov al, [eax+0x27] */
            ii(0x1014_8d9f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8da2, 3); mov(memb_a32[ds, edx + 0x27], al);      /* mov [edx+0x27], al */
            ii(0x1014_8da5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8da8, 3); mov(al, memb_a32[ds, eax + 0x28]);      /* mov al, [eax+0x28] */
            ii(0x1014_8dab, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8dae, 3); mov(memb_a32[ds, edx + 0x28], al);      /* mov [edx+0x28], al */
            ii(0x1014_8db1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8db4, 3); mov(al, memb_a32[ds, eax + 0x29]);      /* mov al, [eax+0x29] */
            ii(0x1014_8db7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8dba, 3); mov(memb_a32[ds, edx + 0x29], al);      /* mov [edx+0x29], al */
            ii(0x1014_8dbd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8dc0, 3); mov(al, memb_a32[ds, eax + 0x2a]);      /* mov al, [eax+0x2a] */
            ii(0x1014_8dc3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8dc6, 3); mov(memb_a32[ds, edx + 0x2a], al);      /* mov [edx+0x2a], al */
            ii(0x1014_8dc9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8dcc, 3); mov(al, memb_a32[ds, eax + 0x2b]);      /* mov al, [eax+0x2b] */
            ii(0x1014_8dcf, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8dd2, 3); mov(memb_a32[ds, edx + 0x2b], al);      /* mov [edx+0x2b], al */
            ii(0x1014_8dd5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8dd8, 3); mov(al, memb_a32[ds, eax + 0x2c]);      /* mov al, [eax+0x2c] */
            ii(0x1014_8ddb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8dde, 3); mov(memb_a32[ds, edx + 0x2c], al);      /* mov [edx+0x2c], al */
            ii(0x1014_8de1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8de4, 3); mov(al, memb_a32[ds, eax + 0x2d]);      /* mov al, [eax+0x2d] */
            ii(0x1014_8de7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8dea, 3); mov(memb_a32[ds, edx + 0x2d], al);      /* mov [edx+0x2d], al */
            ii(0x1014_8ded, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8df0, 3); mov(al, memb_a32[ds, eax + 0x2e]);      /* mov al, [eax+0x2e] */
            ii(0x1014_8df3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8df6, 3); mov(memb_a32[ds, edx + 0x2e], al);      /* mov [edx+0x2e], al */
            ii(0x1014_8df9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8dfc, 3); mov(al, memb_a32[ds, eax + 0x2f]);      /* mov al, [eax+0x2f] */
            ii(0x1014_8dff, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e02, 3); mov(memb_a32[ds, edx + 0x2f], al);      /* mov [edx+0x2f], al */
            ii(0x1014_8e05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e08, 3); mov(al, memb_a32[ds, eax + 0x30]);      /* mov al, [eax+0x30] */
            ii(0x1014_8e0b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e0e, 3); mov(memb_a32[ds, edx + 0x30], al);      /* mov [edx+0x30], al */
            ii(0x1014_8e11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e14, 4); mov(ax, memw_a32[ds, eax + 0x31]);      /* mov ax, [eax+0x31] */
            ii(0x1014_8e18, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e1b, 4); mov(memw_a32[ds, edx + 0x31], ax);      /* mov [edx+0x31], ax */
            ii(0x1014_8e1f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e22, 4); mov(ax, memw_a32[ds, eax + 0x33]);      /* mov ax, [eax+0x33] */
            ii(0x1014_8e26, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e29, 4); mov(memw_a32[ds, edx + 0x33], ax);      /* mov [edx+0x33], ax */
            ii(0x1014_8e2d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e30, 4); mov(ax, memw_a32[ds, eax + 0x35]);      /* mov ax, [eax+0x35] */
            ii(0x1014_8e34, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e37, 4); mov(memw_a32[ds, edx + 0x35], ax);      /* mov [edx+0x35], ax */
            ii(0x1014_8e3b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e3e, 4); mov(ax, memw_a32[ds, eax + 0x37]);      /* mov ax, [eax+0x37] */
            ii(0x1014_8e42, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e45, 4); mov(memw_a32[ds, edx + 0x37], ax);      /* mov [edx+0x37], ax */
            ii(0x1014_8e49, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e4c, 4); mov(ax, memw_a32[ds, eax + 0x39]);      /* mov ax, [eax+0x39] */
            ii(0x1014_8e50, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e53, 4); mov(memw_a32[ds, edx + 0x39], ax);      /* mov [edx+0x39], ax */
            ii(0x1014_8e57, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e5a, 4); mov(ax, memw_a32[ds, eax + 0x3b]);      /* mov ax, [eax+0x3b] */
            ii(0x1014_8e5e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e61, 4); mov(memw_a32[ds, edx + 0x3b], ax);      /* mov [edx+0x3b], ax */
            ii(0x1014_8e65, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e68, 3); mov(al, memb_a32[ds, eax + 0x3d]);      /* mov al, [eax+0x3d] */
            ii(0x1014_8e6b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e6e, 3); mov(memb_a32[ds, edx + 0x3d], al);      /* mov [edx+0x3d], al */
            ii(0x1014_8e71, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e74, 3); mov(al, memb_a32[ds, eax + 0x3e]);      /* mov al, [eax+0x3e] */
            ii(0x1014_8e77, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e7a, 3); mov(memb_a32[ds, edx + 0x3e], al);      /* mov [edx+0x3e], al */
            ii(0x1014_8e7d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e80, 3); mov(al, memb_a32[ds, eax + 0x3f]);      /* mov al, [eax+0x3f] */
            ii(0x1014_8e83, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e86, 3); mov(memb_a32[ds, edx + 0x3f], al);      /* mov [edx+0x3f], al */
            ii(0x1014_8e89, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e8c, 3); mov(al, memb_a32[ds, eax + 0x40]);      /* mov al, [eax+0x40] */
            ii(0x1014_8e8f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8e92, 3); mov(memb_a32[ds, edx + 0x40], al);      /* mov [edx+0x40], al */
            ii(0x1014_8e95, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8e98, 4); mov(dx, memw_a32[ds, eax + 0x41]);      /* mov dx, [eax+0x41] */
            ii(0x1014_8e9c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8e9f, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1014_8ea3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8ea6, 4); mov(dx, memw_a32[ds, eax + 0x43]);      /* mov dx, [eax+0x43] */
            ii(0x1014_8eaa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8ead, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1014_8eb1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8eb4, 3); mov(dl, memb_a32[ds, eax + 0x45]);      /* mov dl, [eax+0x45] */
            ii(0x1014_8eb7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8eba, 3); mov(memb_a32[ds, eax + 0x45], dl);      /* mov [eax+0x45], dl */
            ii(0x1014_8ebd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8ec0, 3); mov(dl, memb_a32[ds, eax + 0x46]);      /* mov dl, [eax+0x46] */
            ii(0x1014_8ec3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8ec6, 3); mov(memb_a32[ds, eax + 0x46], dl);      /* mov [eax+0x46], dl */
            ii(0x1014_8ec9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8ecc, 3); mov(dl, memb_a32[ds, eax + 0x47]);      /* mov dl, [eax+0x47] */
            ii(0x1014_8ecf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8ed2, 3); mov(memb_a32[ds, eax + 0x47], dl);      /* mov [eax+0x47], dl */
            ii(0x1014_8ed5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8ed8, 3); mov(al, memb_a32[ds, eax + 0x48]);      /* mov al, [eax+0x48] */
            ii(0x1014_8edb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8ede, 3); mov(memb_a32[ds, edx + 0x48], al);      /* mov [edx+0x48], al */
            ii(0x1014_8ee1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8ee4, 3); mov(al, memb_a32[ds, eax + 0x49]);      /* mov al, [eax+0x49] */
            ii(0x1014_8ee7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8eea, 3); mov(memb_a32[ds, edx + 0x49], al);      /* mov [edx+0x49], al */
            ii(0x1014_8eed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8ef0, 3); mov(al, memb_a32[ds, eax + 0x4a]);      /* mov al, [eax+0x4a] */
            ii(0x1014_8ef3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8ef6, 3); mov(memb_a32[ds, edx + 0x4a], al);      /* mov [edx+0x4a], al */
            ii(0x1014_8ef9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8efc, 3); mov(al, memb_a32[ds, eax + 0x4b]);      /* mov al, [eax+0x4b] */
            ii(0x1014_8eff, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f02, 3); mov(memb_a32[ds, edx + 0x4b], al);      /* mov [edx+0x4b], al */
            ii(0x1014_8f05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f08, 3); mov(al, memb_a32[ds, eax + 0x4c]);      /* mov al, [eax+0x4c] */
            ii(0x1014_8f0b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f0e, 3); mov(memb_a32[ds, edx + 0x4c], al);      /* mov [edx+0x4c], al */
            ii(0x1014_8f11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f14, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1014_8f17, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f1a, 3); mov(memb_a32[ds, edx + 0x4d], al);      /* mov [edx+0x4d], al */
            ii(0x1014_8f1d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f20, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1014_8f23, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f26, 3); mov(memb_a32[ds, edx + 0x4e], al);      /* mov [edx+0x4e], al */
            ii(0x1014_8f29, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f2c, 3); mov(al, memb_a32[ds, eax + 0x4f]);      /* mov al, [eax+0x4f] */
            ii(0x1014_8f2f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f32, 3); mov(memb_a32[ds, edx + 0x4f], al);      /* mov [edx+0x4f], al */
            ii(0x1014_8f35, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f38, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x1014_8f3b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f3e, 3); mov(memb_a32[ds, edx + 0x50], al);      /* mov [edx+0x50], al */
            ii(0x1014_8f41, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f44, 3); mov(al, memb_a32[ds, eax + 0x51]);      /* mov al, [eax+0x51] */
            ii(0x1014_8f47, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f4a, 3); mov(memb_a32[ds, edx + 0x51], al);      /* mov [edx+0x51], al */
            ii(0x1014_8f4d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f50, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1014_8f54, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f57, 4); mov(memw_a32[ds, edx + 0x52], ax);      /* mov [edx+0x52], ax */
            ii(0x1014_8f5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f5e, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1014_8f61, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f64, 3); mov(memb_a32[ds, edx + 0x54], al);      /* mov [edx+0x54], al */
            ii(0x1014_8f67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f6a, 3); mov(al, memb_a32[ds, eax + 0x55]);      /* mov al, [eax+0x55] */
            ii(0x1014_8f6d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f70, 3); mov(memb_a32[ds, edx + 0x55], al);      /* mov [edx+0x55], al */
            ii(0x1014_8f73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f76, 3); mov(al, memb_a32[ds, eax + 0x56]);      /* mov al, [eax+0x56] */
            ii(0x1014_8f79, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f7c, 3); mov(memb_a32[ds, edx + 0x56], al);      /* mov [edx+0x56], al */
            ii(0x1014_8f7f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f82, 3); mov(al, memb_a32[ds, eax + 0x57]);      /* mov al, [eax+0x57] */
            ii(0x1014_8f85, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f88, 3); mov(memb_a32[ds, edx + 0x57], al);      /* mov [edx+0x57], al */
            ii(0x1014_8f8b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f8e, 3); mov(al, memb_a32[ds, eax + 0x58]);      /* mov al, [eax+0x58] */
            ii(0x1014_8f91, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8f94, 3); mov(memb_a32[ds, edx + 0x58], al);      /* mov [edx+0x58], al */
            ii(0x1014_8f97, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8f9a, 3); mov(al, memb_a32[ds, eax + 0x59]);      /* mov al, [eax+0x59] */
            ii(0x1014_8f9d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8fa0, 3); mov(memb_a32[ds, edx + 0x59], al);      /* mov [edx+0x59], al */
            ii(0x1014_8fa3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8fa6, 3); mov(al, memb_a32[ds, eax + 0x5a]);      /* mov al, [eax+0x5a] */
            ii(0x1014_8fa9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8fac, 3); mov(memb_a32[ds, edx + 0x5a], al);      /* mov [edx+0x5a], al */
            ii(0x1014_8faf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8fb2, 3); mov(al, memb_a32[ds, eax + 0x5b]);      /* mov al, [eax+0x5b] */
            ii(0x1014_8fb5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8fb8, 3); mov(memb_a32[ds, edx + 0x5b], al);      /* mov [edx+0x5b], al */
            ii(0x1014_8fbb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8fbe, 3); mov(al, memb_a32[ds, eax + 0x5c]);      /* mov al, [eax+0x5c] */
            ii(0x1014_8fc1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_8fc4, 3); mov(memb_a32[ds, edx + 0x5c], al);      /* mov [edx+0x5c], al */
            ii(0x1014_8fc7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8fca, 3); mov(dl, memb_a32[ds, eax + 0x5d]);      /* mov dl, [eax+0x5d] */
            ii(0x1014_8fcd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8fd0, 3); mov(memb_a32[ds, eax + 0x5d], dl);      /* mov [eax+0x5d], dl */
            ii(0x1014_8fd3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8fd6, 3); mov(dl, memb_a32[ds, eax + 0x5e]);      /* mov dl, [eax+0x5e] */
            ii(0x1014_8fd9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8fdc, 3); mov(memb_a32[ds, eax + 0x5e], dl);      /* mov [eax+0x5e], dl */
            ii(0x1014_8fdf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8fe2, 3); mov(dl, memb_a32[ds, eax + 0x5f]);      /* mov dl, [eax+0x5f] */
            ii(0x1014_8fe5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8fe8, 3); mov(memb_a32[ds, eax + 0x5f], dl);      /* mov [eax+0x5f], dl */
            ii(0x1014_8feb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8fee, 3); mov(dl, memb_a32[ds, eax + 0x60]);      /* mov dl, [eax+0x60] */
            ii(0x1014_8ff1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8ff4, 3); mov(memb_a32[ds, eax + 0x60], dl);      /* mov [eax+0x60], dl */
            ii(0x1014_8ff7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8ffa, 3); mov(dl, memb_a32[ds, eax + 0x61]);      /* mov dl, [eax+0x61] */
            ii(0x1014_8ffd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9000, 3); mov(memb_a32[ds, eax + 0x61], dl);      /* mov [eax+0x61], dl */
            ii(0x1014_9003, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9006, 3); mov(dl, memb_a32[ds, eax + 0x62]);      /* mov dl, [eax+0x62] */
            ii(0x1014_9009, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_900c, 3); mov(memb_a32[ds, eax + 0x62], dl);      /* mov [eax+0x62], dl */
            ii(0x1014_900f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9012, 3); mov(dl, memb_a32[ds, eax + 0x63]);      /* mov dl, [eax+0x63] */
            ii(0x1014_9015, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9018, 3); mov(memb_a32[ds, eax + 0x63], dl);      /* mov [eax+0x63], dl */
            ii(0x1014_901b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_901e, 3); mov(dl, memb_a32[ds, eax + 0x64]);      /* mov dl, [eax+0x64] */
            ii(0x1014_9021, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9024, 3); mov(memb_a32[ds, eax + 0x64], dl);      /* mov [eax+0x64], dl */
            ii(0x1014_9027, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_902a, 3); add(edx, 0x65);                         /* add edx, 0x65 */
            ii(0x1014_902d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9030, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_9033, 5); calld(0x1012_0c64, -0x2_83d4);          /* call 0x10120c64 */
            ii(0x1014_9038, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_903b, 4); mov(dx, memw_a32[ds, eax + 0x69]);      /* mov dx, [eax+0x69] */
            ii(0x1014_903f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9042, 4); mov(memw_a32[ds, eax + 0x69], dx);      /* mov [eax+0x69], dx */
            ii(0x1014_9046, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9049, 3); mov(dl, memb_a32[ds, eax + 0x6b]);      /* mov dl, [eax+0x6b] */
            ii(0x1014_904c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_904f, 3); mov(memb_a32[ds, eax + 0x6b], dl);      /* mov [eax+0x6b], dl */
            ii(0x1014_9052, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_9055, 3); add(edx, 0x6c);                         /* add edx, 0x6c */
            ii(0x1014_9058, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_905b, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_905e, 5); calld(0x1015_5280, 0xc21d);             /* call 0x10155280 */
            ii(0x1014_9063, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_9066, 3); add(edx, 0x70);                         /* add edx, 0x70 */
            ii(0x1014_9069, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_906c, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_906f, 5); calld(0x1015_5344, 0xc2d0);             /* call 0x10155344 */
            ii(0x1014_9074, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_9077, 3); add(edx, 0x74);                         /* add edx, 0x74 */
            ii(0x1014_907a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_907d, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_9080, 5); calld(0x100d_5494, -0x7_3bf1);          /* call 0x100d5494 */
            ii(0x1014_9085, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9088, 4); mov(ax, memw_a32[ds, eax + 0x78]);      /* mov ax, [eax+0x78] */
            ii(0x1014_908c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_908f, 4); mov(memw_a32[ds, edx + 0x78], ax);      /* mov [edx+0x78], ax */
            ii(0x1014_9093, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9096, 3); mov(al, memb_a32[ds, eax + 0x7a]);      /* mov al, [eax+0x7a] */
            ii(0x1014_9099, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_909c, 3); mov(memb_a32[ds, edx + 0x7a], al);      /* mov [edx+0x7a], al */
            ii(0x1014_909f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_90a2, 3); mov(dl, memb_a32[ds, eax + 0x7b]);      /* mov dl, [eax+0x7b] */
            ii(0x1014_90a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_90a8, 3); mov(memb_a32[ds, eax + 0x7b], dl);      /* mov [eax+0x7b], dl */
            ii(0x1014_90ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_90ae, 4); mov(dx, memw_a32[ds, eax + 0x7c]);      /* mov dx, [eax+0x7c] */
            ii(0x1014_90b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_90b5, 4); mov(memw_a32[ds, eax + 0x7c], dx);      /* mov [eax+0x7c], dx */
            ii(0x1014_90b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_90bc, 3); mov(edx, memd_a32[ds, eax + 0x7e]);     /* mov edx, [eax+0x7e] */
            ii(0x1014_90bf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_90c2, 3); mov(memd_a32[ds, eax + 0x7e], edx);     /* mov [eax+0x7e], edx */
            ii(0x1014_90c5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_90c8, 6); add(edx, 0x82);                         /* add edx, 0x82 */
            ii(0x1014_90ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_90d1, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_90d6, 5); calld(0x1008_ac18, -0xb_e4c3);          /* call 0x1008ac18 */
            ii(0x1014_90db, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_90de, 6); add(edx, 0x86);                         /* add edx, 0x86 */
            ii(0x1014_90e4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_90e7, 5); add(eax, 0x86);                         /* add eax, 0x86 */
            ii(0x1014_90ec, 5); calld(0x1008_ac18, -0xb_e4d9);          /* call 0x1008ac18 */
            ii(0x1014_90f1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_90f4, 6); add(edx, 0x8a);                         /* add edx, 0x8a */
            ii(0x1014_90fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_90fd, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1014_9102, 5); calld(0x1015_519c, 0xc095);             /* call 0x1015519c */
            ii(0x1014_9107, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_910a, 6); mov(dl, memb_a32[ds, eax + 0x9e]);      /* mov dl, [eax+0x9e] */
            ii(0x1014_9110, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9113, 6); mov(memb_a32[ds, eax + 0x9e], dl);      /* mov [eax+0x9e], dl */
            ii(0x1014_9119, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_911c, 6); add(edx, 0x9f);                         /* add edx, 0x9f */
            ii(0x1014_9122, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9125, 5); add(eax, 0x9f);                         /* add eax, 0x9f */
            ii(0x1014_912a, 5); calld(0x1008_8b44, -0xc_05eb);          /* call 0x10088b44 */
            ii(0x1014_912f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9132, 7); mov(dx, memw_a32[ds, eax + 0xa3]);      /* mov dx, [eax+0xa3] */
            ii(0x1014_9139, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_913c, 7); mov(memw_a32[ds, eax + 0xa3], dx);      /* mov [eax+0xa3], dx */
            ii(0x1014_9143, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9146, 6); mov(dl, memb_a32[ds, eax + 0xa5]);      /* mov dl, [eax+0xa5] */
            ii(0x1014_914c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_914f, 6); mov(memb_a32[ds, eax + 0xa5], dl);      /* mov [eax+0xa5], dl */
            ii(0x1014_9155, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9158, 6); mov(dl, memb_a32[ds, eax + 0xa6]);      /* mov dl, [eax+0xa6] */
            ii(0x1014_915e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9161, 6); mov(memb_a32[ds, eax + 0xa6], dl);      /* mov [eax+0xa6], dl */
            ii(0x1014_9167, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_916a, 10); mov(memd_a32[ds, eax + 0xa7], 0);      /* mov dword [eax+0xa7], 0x0 */
            ii(0x1014_9174, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1014_9179, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_917c, 6); add(edx, 0xab);                         /* add edx, 0xab */
            ii(0x1014_9182, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9185, 5); add(eax, 0xab);                         /* add eax, 0xab */
            ii(0x1014_918a, 5); calld(Definitions.sys_memcpy, 0x1_ccbc); /* call 0x10165e4b */
            ii(0x1014_918f, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1014_9194, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_9197, 6); add(edx, 0xb0);                         /* add edx, 0xb0 */
            ii(0x1014_919d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_91a0, 5); add(eax, 0xb0);                         /* add eax, 0xb0 */
            ii(0x1014_91a5, 5); calld(Definitions.sys_memcpy, 0x1_cca1); /* call 0x10165e4b */
            ii(0x1014_91aa, 3); mov(edi, memd_a32[ss, ebp - 0x8]);      /* mov edi, [ebp-0x8] */
            ii(0x1014_91ad, 6); lea(edi, edi + 0xb5);                   /* lea edi, [edi+0xb5] */
            ii(0x1014_91b3, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x1014_91b6, 6); lea(esi, esi + 0xb5);                   /* lea esi, [esi+0xb5] */
            ii(0x1014_91bc, 1); movsd_a32();                            /* movsd */
            ii(0x1014_91bd, 1); movsd_a32();                            /* movsd */
            ii(0x1014_91be, 1); movsd_a32();                            /* movsd */
            ii(0x1014_91bf, 1); movsd_a32();                            /* movsd */
            ii(0x1014_91c0, 3); mov(edi, memd_a32[ss, ebp - 0x8]);      /* mov edi, [ebp-0x8] */
            ii(0x1014_91c3, 6); lea(edi, edi + 0xc5);                   /* lea edi, [edi+0xc5] */
            ii(0x1014_91c9, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x1014_91cc, 6); lea(esi, esi + 0xc5);                   /* lea esi, [esi+0xc5] */
            ii(0x1014_91d2, 1); movsd_a32();                            /* movsd */
            ii(0x1014_91d3, 1); movsd_a32();                            /* movsd */
            ii(0x1014_91d4, 1); movsd_a32();                            /* movsd */
            ii(0x1014_91d5, 1); movsd_a32();                            /* movsd */
            ii(0x1014_91d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_91d9, 7); mov(dx, memw_a32[ds, eax + 0xd5]);      /* mov dx, [eax+0xd5] */
            ii(0x1014_91e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_91e3, 7); mov(memw_a32[ds, eax + 0xd5], dx);      /* mov [eax+0xd5], dx */
            ii(0x1014_91ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_91ed, 7); mov(dx, memw_a32[ds, eax + 0xd7]);      /* mov dx, [eax+0xd7] */
            ii(0x1014_91f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_91f7, 7); mov(memw_a32[ds, eax + 0xd7], dx);      /* mov [eax+0xd7], dx */
            ii(0x1014_91fe, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_9201, 6); add(edx, 0xd9);                         /* add edx, 0xd9 */
            ii(0x1014_9207, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_920a, 5); add(eax, 0xd9);                         /* add eax, 0xd9 */
            ii(0x1014_920f, 5); calld(0x1008_8b44, -0xc_06d0);          /* call 0x10088b44 */
            ii(0x1014_9214, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9217, 6); mov(edx, memd_a32[ds, eax + 0xdd]);     /* mov edx, [eax+0xdd] */
            ii(0x1014_921d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9220, 6); mov(memd_a32[ds, eax + 0xdd], edx);     /* mov [eax+0xdd], edx */
            ii(0x1014_9226, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9229, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_922c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_922f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_9231, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_9232, 1); popd(edi);                              /* pop edi */
            ii(0x1014_9233, 1); popd(esi);                              /* pop esi */
            ii(0x1014_9234, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_9235, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_9236, 1); retd(); return;                         /* ret */
        }
    }
}
