using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_346f-f6be8173")]
        public void Method_1012_346f()
        {
            ii(0x1012_346f, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_3474, 5); calld(Definitions.sys_check_available_stack_size, 0x4_28d9); /* call 0x10165d52 */
            ii(0x1012_3479, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_347a, 1); pushd(esi);                             /* push esi */
            ii(0x1012_347b, 1); pushd(edi);                             /* push edi */
            ii(0x1012_347c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_347d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_347f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_3485, 3); mov(edx, memd_a32[ss, ebp + 0x18]);     /* mov edx, [ebp+0x18] */
            ii(0x1012_3488, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_348b, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1012_348e, 5); calld(Definitions.sys_strcpy, 0x4_2a3c); /* call 0x10165ecf */
            ii(0x1012_3493, 5); pushd(0x200);                           /* push 0x200 */
            ii(0x1012_3498, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1012_349b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_349c, 5); calld(/* sys */ 0x1017_cf25, 0x5_9a84); /* call 0x1017cf25 */
            ii(0x1012_34a1, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1012_34a4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_34a7, 4); cmp(memd_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp dword [ebp-0x4], 0xffffffff */
            ii(0x1012_34ab, 2); if(jnzd(0x1012_34b9, 0xc)) goto l_0x1012_34b9; /* jnz 0x101234b9 */
            ii(0x1012_34ad, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_34b4, 5); jmpd(0x1012_3613, 0x15a); goto l_0x1012_3613; /* jmp 0x10123613 */
        l_0x1012_34b9:
            ii(0x1012_34b9, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1012_34be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_34c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_34c3, 5); calld(Definitions.sys_lseek, 0x5_9ccf); /* call 0x1017d197 */
            ii(0x1012_34c8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_34ca, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_34cd, 6); mov(memd_a32[ds, eax + 0x88], edx);     /* mov [eax+0x88], edx */
            ii(0x1012_34d3, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_34d6, 6); mov(eax, memd_a32[ds, eax + 0x88]);     /* mov eax, [eax+0x88] */
            ii(0x1012_34dc, 5); add(eax, 0x400);                        /* add eax, 0x400 */
            ii(0x1012_34e1, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1012_34e4, 6); mov(memd_a32[ds, edx + 0x8c], eax);     /* mov [edx+0x8c], eax */
            ii(0x1012_34ea, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_34ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_34ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_34f1, 5); calld(Definitions.sys_lseek, 0x5_9ca1); /* call 0x1017d197 */
            ii(0x1012_34f6, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_34f9, 6); mov(eax, memd_a32[ds, eax + 0x8c]);     /* mov eax, [eax+0x8c] */
            ii(0x1012_34ff, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1012_3502, 5); calld(Definitions.sys_malloc, 0x4_7ad7); /* call 0x1016afde */
            ii(0x1012_3507, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_3509, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_350c, 6); mov(memd_a32[ds, eax + 0x84], edx);     /* mov [eax+0x84], edx */
            ii(0x1012_3512, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3515, 7); cmp(memd_a32[ds, eax + 0x84], 0);       /* cmp dword [eax+0x84], 0x0 */
            ii(0x1012_351c, 2); if(jnzd(0x1012_3532, 0x14)) goto l_0x1012_3532; /* jnz 0x10123532 */
            ii(0x1012_351e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_3521, 5); calld(/* sys */ 0x1017_d1da, 0x5_9cb4); /* call 0x1017d1da */
            ii(0x1012_3526, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_352d, 5); jmpd(0x1012_3613, 0xe1); goto l_0x1012_3613; /* jmp 0x10123613 */
        l_0x1012_3532:
            ii(0x1012_3532, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3535, 6); mov(ebx, memd_a32[ds, eax + 0x88]);     /* mov ebx, [eax+0x88] */
            ii(0x1012_353b, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_353e, 6); mov(edx, memd_a32[ds, eax + 0x84]);     /* mov edx, [eax+0x84] */
            ii(0x1012_3544, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_3547, 5); calld(/* sys */ 0x1017_d1fa, 0x5_9cae); /* call 0x1017d1fa */
            ii(0x1012_354c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_354e, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3551, 6); cmp(edx, memd_a32[ds, eax + 0x88]);     /* cmp edx, [eax+0x88] */
            ii(0x1012_3557, 2); if(jzd(0x1012_357b, 0x22)) goto l_0x1012_357b; /* jz 0x1012357b */
            ii(0x1012_3559, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_355c, 5); calld(/* sys */ 0x1017_d1da, 0x5_9c79); /* call 0x1017d1da */
            ii(0x1012_3561, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3564, 6); mov(eax, memd_a32[ds, eax + 0x84]);     /* mov eax, [eax+0x84] */
            ii(0x1012_356a, 5); calld(Definitions.sys_free, 0x4_7b52);  /* call 0x1016b0c1 */
            ii(0x1012_356f, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_3576, 5); jmpd(0x1012_3613, 0x98); goto l_0x1012_3613; /* jmp 0x10123613 */
        l_0x1012_357b:
            ii(0x1012_357b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_357e, 5); calld(/* sys */ 0x1017_d1da, 0x5_9c57); /* call 0x1017d1da */
            ii(0x1012_3583, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3586, 6); mov(edx, memd_a32[ds, eax + 0x84]);     /* mov edx, [eax+0x84] */
            ii(0x1012_358c, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_358f, 6); mov(eax, memd_a32[ds, eax + 0x88]);     /* mov eax, [eax+0x88] */
            ii(0x1012_3595, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_3597, 3); mov(memb_a32[ds, eax], 0xa);            /* mov byte [eax], 0xa */
            ii(0x1012_359a, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_359d, 6); mov(edx, memd_a32[ds, eax + 0x88]);     /* mov edx, [eax+0x88] */
            ii(0x1012_35a3, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_35a6, 6); mov(eax, memd_a32[ds, eax + 0x84]);     /* mov eax, [eax+0x84] */
            ii(0x1012_35ac, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_35ae, 4); mov(memb_a32[ds, eax + 0x1], 0xd);      /* mov byte [eax+0x1], 0xd */
            ii(0x1012_35b2, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_35b5, 6); mov(edx, memd_a32[ds, eax + 0x84]);     /* mov edx, [eax+0x84] */
            ii(0x1012_35bb, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_35be, 6); mov(memd_a32[ds, eax + 0x90], edx);     /* mov [eax+0x90], edx */
            ii(0x1012_35c4, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_35c7, 10); mov(memd_a32[ds, eax + 0x94], 0);      /* mov dword [eax+0x94], 0x0 */
            ii(0x1012_35d1, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_35d4, 10); mov(memd_a32[ds, eax + 0xa0], 0);      /* mov dword [eax+0xa0], 0x0 */
            ii(0x1012_35de, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_35e1, 10); mov(memd_a32[ds, eax + 0xa4], 0);      /* mov dword [eax+0xa4], 0x0 */
            ii(0x1012_35eb, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_35ee, 10); mov(memd_a32[ds, eax + 0x9c], 0);      /* mov dword [eax+0x9c], 0x0 */
            ii(0x1012_35f8, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_35fb, 10); mov(memd_a32[ds, eax + 0xa8], 0);      /* mov dword [eax+0xa8], 0x0 */
            ii(0x1012_3605, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3608, 4); and(memb_a32[ds, eax + 0x1], 0x7f);     /* and byte [eax+0x1], 0x7f */
            ii(0x1012_360c, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
        l_0x1012_3613:
            ii(0x1012_3613, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_3616, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_3618, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_3619, 1); popd(edi);                              /* pop edi */
            ii(0x1012_361a, 1); popd(esi);                              /* pop esi */
            ii(0x1012_361b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_361c, 1); retd();                                 /* ret */
        }
    }
}
