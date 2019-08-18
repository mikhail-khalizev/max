using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_91ec-812f6310")]
        public void Method_100e_91ec()
        {
            ii(0x100e_91ec, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x100e_91f1, 5); calld(Definitions.sys_check_available_stack_size, 0x7_cb5c); /* call 0x10165d52 */
            ii(0x100e_91f6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_91f7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_91f8, 1); pushd(edx);                             /* push edx */
            ii(0x100e_91f9, 1); pushd(esi);                             /* push esi */
            ii(0x100e_91fa, 1); pushd(edi);                             /* push edi */
            ii(0x100e_91fb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_91fc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_91fe, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100e_9204, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_9207, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100e_920a, 2); mov(cl, memb_a32[ds, ecx]);             /* mov cl, [ecx] */
            ii(0x100e_920c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_9211, 2); shl(eax, cl);                           /* shl eax, cl */
            ii(0x100e_9213, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_9216, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9219, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100e_921c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_921f, 3); imul(eax, eax, 0x7);                    /* imul eax, eax, 0x7 */
            ii(0x100e_9222, 6); mov(ecx, memd_a32[ds, Definitions.ptr_arr_meta_by_id]); /* mov ecx, [0x101c70ec] */
            ii(0x100e_9228, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100e_922a, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x100e_922d, 5); mov(memd_a32[ds, 0x101c_363c], eax);    /* mov [0x101c363c], eax */
            ii(0x100e_9232, 7); cmp(memd_a32[ds, 0x101c_363c], 0);      /* cmp dword [0x101c363c], 0x0 */
            ii(0x100e_9239, 2); if(jnzd(0x100e_928a, 0x4f)) goto l_0x100e_928a; /* jnz 0x100e928a */
            ii(0x100e_923b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_923e, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100e_9241, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_9244, 5); calld(Definitions.my_get_res_data_by_id, 0x4_ad8f); /* call 0x10133fd8 */
            ii(0x100e_9249, 5); mov(memd_a32[ds, 0x101c_363c], eax);    /* mov [0x101c363c], eax */
            ii(0x100e_924e, 7); cmp(memd_a32[ds, 0x101c_363c], 0);      /* cmp dword [0x101c363c], 0x0 */
            ii(0x100e_9255, 6); if(jzd(0x100e_9390, 0x135)) goto l_0x100e_9390; /* jz 0x100e9390 */
            ii(0x100e_925b, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x100e_925f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_9261, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100e_9264, 5); mov(eax, memd_a32[ds, 0x101c_363c]);    /* mov eax, [0x101c363c] */
            ii(0x100e_9269, 5); calld(0x1015_aefb, 0x7_1c8d);           /* call 0x1015aefb */
            ii(0x100e_926e, 5); mov(memd_a32[ds, 0x101c_363c], eax);    /* mov [0x101c363c], eax */
            ii(0x100e_9273, 3); mov(ebx, memd_a32[ss, ebp - 0x2c]);     /* mov ebx, [ebp-0x2c] */
            ii(0x100e_9276, 6); mov(edx, memd_a32[ds, 0x101c_363c]);    /* mov edx, [0x101c363c] */
            ii(0x100e_927c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_927f, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100e_9282, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_9285, 5); calld(0x1013_4157, 0x4_aecd);           /* call 0x10134157 */
        l_0x100e_928a:
            ii(0x100e_928a, 5); mov(eax, memd_a32[ds, 0x101c_363c]);    /* mov eax, [0x101c363c] */
            ii(0x100e_928f, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_9292, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9295, 3); mov(eax, memd_a32[ds, eax + 0x22]);     /* mov eax, [eax+0x22] */
            ii(0x100e_9298, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_929b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_929e, 3); add(eax, memd_a32[ss, ebp - 0x24]);     /* add eax, [ebp-0x24] */
            ii(0x100e_92a1, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x100e_92a4, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_92a7, 5); mov(eax, memd_a32[ds, 0x101c_363c]);    /* mov eax, [0x101c363c] */
            ii(0x100e_92ac, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x100e_92af, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_92b1, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x100e_92b4, 5); mov(eax, memd_a32[ds, 0x101c_38c4]);    /* mov eax, [0x101c38c4] */
            ii(0x100e_92b9, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_92bc, 6); mov(ax, memw_a32[ds, 0x101c_38fc]);     /* mov ax, [0x101c38fc] */
            ii(0x100e_92c2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_92c5, 6); mov(ax, memw_a32[ds, 0x101c_38fe]);     /* mov ax, [0x101c38fe] */
            ii(0x100e_92cb, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_92ce, 10); mov(memd_a32[ds, 0x101c_38c4], 0x1_0000); /* mov dword [0x101c38c4], 0x10000 */
            ii(0x100e_92d8, 9); mov(memw_a32[ds, 0x101c_38fc], 0);      /* mov word [0x101c38fc], 0x0 */
            ii(0x100e_92e1, 9); mov(memw_a32[ds, 0x101c_38fe], 0);      /* mov word [0x101c38fe], 0x0 */
            ii(0x100e_92ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_92ed, 3); mov(ebx, memd_a32[ds, eax + 0x20]);     /* mov ebx, [eax+0x20] */
            ii(0x100e_92f0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_92f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_92f6, 3); mov(edx, memd_a32[ds, eax + 0x1e]);     /* mov edx, [eax+0x1e] */
            ii(0x100e_92f9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_92fc, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100e_92ff, 5); calld(0x1007_6aac, -0x7_2858);          /* call 0x10076aac */
            ii(0x100e_9304, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9307, 4); mov(ax, memw_a32[ds, eax + 0xe]);       /* mov ax, [eax+0xe] */
            ii(0x100e_930b, 6); mov(memw_a32[ds, 0x101b_7f5c], ax);     /* mov [0x101b7f5c], ax */
            ii(0x100e_9311, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100e_9314, 3); add(ecx, 0x10);                         /* add ecx, 0x10 */
            ii(0x100e_9317, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100e_931c, 3); mov(esi, memd_a32[ss, ebp - 0x1c]);     /* mov esi, [ebp-0x1c] */
            ii(0x100e_931f, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100e_9322, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_9325, 5); calld(0x1007_5e64, -0x7_34c6);          /* call 0x10075e64 */
            ii(0x100e_932a, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x100e_932c, 5); calld(0x1015_2cba, 0x6_9989);           /* call 0x10152cba */
            ii(0x100e_9331, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_9333, 2); if(jzd(0x100e_936d, 0x38)) goto l_0x100e_936d; /* jz 0x100e936d */
            ii(0x100e_9335, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_9338, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100e_933b, 5); mov(memd_a32[ds, 0x101c_3634], eax);    /* mov [0x101c3634], eax */
            ii(0x100e_9340, 7); mov(memb_a32[ds, 0x101c_3645], 0);      /* mov byte [0x101c3645], 0x0 */
            ii(0x100e_9347, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_934a, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x100e_934d, 5); mov(memd_a32[ds, 0x101c_3640], eax);    /* mov [0x101c3640], eax */
            ii(0x100e_9352, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9355, 3); mov(al, memb_a32[ds, eax + 0x6]);       /* mov al, [eax+0x6] */
            ii(0x100e_9358, 5); mov(memb_a32[ds, 0x101c_3644], al);     /* mov [0x101c3644], al */
            ii(0x100e_935d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9360, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100e_9363, 5); mov(memd_a32[ds, 0x101c_9474], eax);    /* mov [0x101c9474], eax */
            ii(0x100e_9368, 5); calld(0x100e_f7f8, 0x648b);             /* call 0x100ef7f8 */
        l_0x100e_936d:
            ii(0x100e_936d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_9370, 5); mov(memd_a32[ds, 0x101c_38c4], eax);    /* mov [0x101c38c4], eax */
            ii(0x100e_9375, 9); mov(memw_a32[ds, 0x101b_7f5c], 0x280);  /* mov word [0x101b7f5c], 0x280 */
            ii(0x100e_937e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9381, 6); mov(memw_a32[ds, 0x101c_38fc], ax);     /* mov [0x101c38fc], ax */
            ii(0x100e_9387, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_938a, 6); mov(memw_a32[ds, 0x101c_38fe], ax);     /* mov [0x101c38fe], ax */
        l_0x100e_9390:
            ii(0x100e_9390, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_9392, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_9393, 1); popd(edi);                              /* pop edi */
            ii(0x100e_9394, 1); popd(esi);                              /* pop esi */
            ii(0x100e_9395, 1); popd(edx);                              /* pop edx */
            ii(0x100e_9396, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_9397, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_9398, 1); retd(); return;                         /* ret */
        }
    }
}
