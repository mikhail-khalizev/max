using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_245e-f38c3ebe")]
        public void Method_1012_245e()
        {
            ii(0x1012_245e, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1012_2463, 5); calld(Definitions.sys_check_available_stack_size, 0x4_38ea); /* call 0x10165d52 */
            ii(0x1012_2468, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_2469, 1); pushd(esi);                             /* push esi */
            ii(0x1012_246a, 1); pushd(edi);                             /* push edi */
            ii(0x1012_246b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_246c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_246e, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1012_2474, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_2477, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_247a, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1012_247d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_2481, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2484, 5); mov(edx, 0x101b_b05c);                  /* mov edx, 0x101bb05c */
            ii(0x1012_2489, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_248b, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x1012_248e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_2491, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1012_2494, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_2497, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1012_249a, 5); calld(0x100d_7f6c, -0x4_a533);          /* call 0x100d7f6c */
            ii(0x1012_249f, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1012_24a3, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_24a6, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_24a9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_24ac, 5); calld(0x1007_6e7c, -0xa_b635);          /* call 0x10076e7c */
            ii(0x1012_24b1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_24b3, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_24b6, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1012_24b9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_24bc, 5); calld(Definitions.my_min, -0x9_8d3d);   /* call 0x10089784 */
            ii(0x1012_24c1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_24c4, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_24c7, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1012_24ca, 5); calld(0x100d_4ef0, -0x4_d5df);          /* call 0x100d4ef0 */
            ii(0x1012_24cf, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1012_24d4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_24d7, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_24da, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1012_24dd, 5); calld(0x100d_4ebc, -0x4_d626);          /* call 0x100d4ebc */
            ii(0x1012_24e2, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1012_24e5, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_24e8, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1012_24eb, 5); calld(0x100d_4f58, -0x4_d598);          /* call 0x100d4f58 */
            ii(0x1012_24f0, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x1012_24f3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_24f6, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_24f9, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1012_24fc, 5); calld(0x100d_4f24, -0x4_d5dd);          /* call 0x100d4f24 */
            ii(0x1012_2501, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1012_2504, 5); mov(eax, 0x183);                        /* mov eax, 0x183 */
            ii(0x1012_2509, 5); calld(Definitions.my_get_res_data_by_id, 0x1_1aca); /* call 0x10133fd8 */
            ii(0x1012_250e, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1012_2511, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1012_2514, 3); movsx(edx, memw_a32[ds, edx]);          /* movsx edx, word [edx] */
            ii(0x1012_2517, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_251b, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1012_251e, 3); mov(ebx, memd_a32[ss, ebp - 0x20]);     /* mov ebx, [ebp-0x20] */
            ii(0x1012_2521, 3); mov(ebx, memd_a32[ds, ebx + 0x8]);      /* mov ebx, [ebx+0x8] */
            ii(0x1012_2524, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_2527, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_2529, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_252c, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_252e, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1012_2532, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_2534, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1012_2537, 5); mov(eax, 0x182);                        /* mov eax, 0x182 */
            ii(0x1012_253c, 5); calld(Definitions.my_get_res_data_by_id, 0x1_1a97); /* call 0x10133fd8 */
            ii(0x1012_2541, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1012_2544, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1012_2547, 3); movsx(edx, memw_a32[ds, edx]);          /* movsx edx, word [edx] */
            ii(0x1012_254a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_254c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_254f, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_2551, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1012_2553, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1012_2557, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_2559, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1012_255c, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1012_255f, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1012_2561, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_2564, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_2569, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_256b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_256d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_256f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_2572, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_2574, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1012_2576, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1012_257a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_257c, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1012_257f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_2582, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1012_2585, 1); pushd(eax);                             /* push eax */
            ii(0x1012_2586, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1012_258b, 4); movsx(ebx, memw_a32[ss, ebp - 0x2c]);   /* movsx ebx, word [ebp-0x2c] */
            ii(0x1012_258f, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1012_2593, 5); mov(eax, 0x182);                        /* mov eax, 0x182 */
            ii(0x1012_2598, 5); calld(0x100e_8ef1, -0x3_96ac);          /* call 0x100e8ef1 */
            ii(0x1012_259d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_25a0, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1012_25a3, 4); mov(memw_a32[ds, edx + 0x18], ax);      /* mov [edx+0x18], ax */
            ii(0x1012_25a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_25a9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_25aa, 1); popd(edi);                              /* pop edi */
            ii(0x1012_25ab, 1); popd(esi);                              /* pop esi */
            ii(0x1012_25ac, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_25ad, 1); retd(); return;                         /* ret */
        }
    }
}
