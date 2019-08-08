using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f2c00b16-a25e-4c2e-b974-83a535f65fde")]
        public void Method_1016_3378()
        {
            ii(0x1016_3378, 5); pushd(0x68);                            /* push 0x68 */
            ii(0x1016_337d, 5); calld(Definitions.sys_check_available_stack_size, 0x29d0); /* call 0x10165d52 */
            ii(0x1016_3382, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_3383, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_3384, 1); pushd(edx);                             /* push edx */
            ii(0x1016_3385, 1); pushd(esi);                             /* push esi */
            ii(0x1016_3386, 1); pushd(edi);                             /* push edi */
            ii(0x1016_3387, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_3388, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_338a, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1016_3390, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_3393, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_3396, 5); cmp(memw_a32[ds, eax + 0x8], 0x3d);     /* cmp word [eax+0x8], 0x3d */
            ii(0x1016_339b, 2); if(jnzd(0x1016_33b9, 0x1c)) goto l_0x1016_33b9; /* jnz 0x101633b9 */
            ii(0x1016_339d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_33a0, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1016_33a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_33a7, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1016_33ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_33ae, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1016_33b2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_33b5, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
        l_0x1016_33b9:
            ii(0x1016_33b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_33bc, 3); mov(dl, memb_a32[ds, eax + 0x3f]);      /* mov dl, [eax+0x3f] */
            ii(0x1016_33bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_33c2, 3); mov(memb_a32[ds, eax + 0x3d], dl);      /* mov [eax+0x3d], dl */
            ii(0x1016_33c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_33c8, 3); mov(dl, memb_a32[ds, eax + 0x40]);      /* mov dl, [eax+0x40] */
            ii(0x1016_33cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_33ce, 3); mov(memb_a32[ds, eax + 0x3e], dl);      /* mov [eax+0x3e], dl */
            ii(0x1016_33d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_33d4, 5); calld(0x1015_2387, -0x1_1052);          /* call 0x10152387 */
            ii(0x1016_33d9, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1016_33dd, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1016_33e0, 5); calld(Definitions.my_string_ctor, -0x2_18fd); /* call 0x10141ae8 */
            ii(0x1016_33e5, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1016_33e8, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1016_33ec, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1016_33ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_33f2, 5); calld(0x1015_0a5f, -0x1_2998);          /* call 0x10150a5f */
            ii(0x1016_33f7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_33f9, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1016_33fc, 5); calld(0x1008_b228, -0xd_81d9);          /* call 0x1008b228 */
            ii(0x1016_3401, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1016_3404, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_3407, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_340a, 5); calld(0x1009_c9a0, -0xc_6a6f);          /* call 0x1009c9a0 */
            ii(0x1016_340f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1016_3412, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1016_3415, 5); calld(Definitions.my_2_get_count, -0xd_80b2); /* call 0x1008b368 */
            ii(0x1016_341a, 1); cwde();                                 /* cwde */
            ii(0x1016_341b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_341d, 2); if(jled(0x1016_3428, 0x9)) goto l_0x1016_3428; /* jle 0x10163428 */
            ii(0x1016_341f, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1016_3426, 2); jmpd(0x1016_3441, 0x19); goto l_0x1016_3441; /* jmp 0x10163441 */
        l_0x1016_3428:
            ii(0x1016_3428, 5); mov(ecx, 0x1f45);                       /* mov ecx, 0x1f45 */
            ii(0x1016_342d, 5); mov(ebx, StringDefinitions.UnitsmgrCpp3); /* mov ebx, 0x101b29f2 */
            ii(0x1016_3432, 5); mov(edx, StringDefinitions.BuildListGetcountGreater03); /* mov edx, 0x101b29ff */
            ii(0x1016_3437, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_3439, 5); calld(Definitions.sys_assert, 0x2954);  /* call 0x10165d92 */
            ii(0x1016_343e, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1016_3441:
            ii(0x1016_3441, 3); lea(edi, ebp - 0x34);                   /* lea edi, [ebp-0x34] */
            ii(0x1016_3444, 5); mov(esi, 0x101b_dd88);                  /* mov esi, 0x101bdd88 */
            ii(0x1016_3449, 1); movsd_a32();                            /* movsd */
            ii(0x1016_344a, 1); movsd_a32();                            /* movsd */
            ii(0x1016_344b, 1); movsd_a32();                            /* movsd */
            ii(0x1016_344c, 3); lea(ecx, ebp - 0x10);                   /* lea ecx, [ebp-0x10] */
            ii(0x1016_344f, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1016_3453, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1016_3457, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_345a, 5); calld(0x1015_4f88, -0xe4d7);            /* call 0x10154f88 */
            ii(0x1016_345f, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1016_3463, 1); pushd(eax);                             /* push eax */
            ii(0x1016_3464, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_3466, 6); mov(dl, memb_a32[ds, 0x101c_37da]);     /* mov dl, [0x101c37da] */
            ii(0x1016_346c, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1016_3472, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1016_3476, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_3478, 6); mov(al, memb_a32[ds, eax + 0x101c_a492]); /* mov al, [eax+0x101ca492] */
            ii(0x1016_347e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_3483, 1); pushd(eax);                             /* push eax */
            ii(0x1016_3484, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1016_3488, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1016_348b, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x1016_3491, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1016_3495, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1016_3498, 6); mov(eax, memd_a32[ds, eax + 0x101c_81d3]); /* mov eax, [eax+0x101c81d3] */
            ii(0x1016_349e, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1016_34a1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_34a4, 4); pushd(memd_a32[ds, eax + ebp - 0x34]);  /* push dword [eax+ebp-0x34] */
            ii(0x1016_34a8, 5); mov(eax, 0xfa);                         /* mov eax, 0xfa */
            ii(0x1016_34ad, 1); pushd(eax);                             /* push eax */
            ii(0x1016_34ae, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1016_34b1, 1); pushd(eax);                             /* push eax */
            ii(0x1016_34b2, 5); calld(0x1014_2037, -0x2_1480);          /* call 0x10142037 */
            ii(0x1016_34b7, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1016_34ba, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1016_34bd, 3); mov(ebx, memd_a32[ds, ebx + 0x1a]);     /* mov ebx, [ebx+0x1a] */
            ii(0x1016_34c0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_34c3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_34c6, 3); mov(edx, memd_a32[ds, edx + 0x18]);     /* mov edx, [edx+0x18] */
            ii(0x1016_34c9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_34cc, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_34cf, 5); calld(0x1007_6aac, -0xe_ca28);          /* call 0x10076aac */
            ii(0x1016_34d4, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1016_34d6, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1016_34d9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_34db, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1016_34de, 5); calld(Definitions.my_strobj_c_str_v2, -0xd_9d1b); /* call 0x100897c8 */
            ii(0x1016_34e3, 5); calld(0x1011_5b60, -0x4_d988);          /* call 0x10115b60 */
            ii(0x1016_34e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_34ea, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1016_34ed, 5); calld(0x1008_8b04, -0xd_a9ee);          /* call 0x10088b04 */
            ii(0x1016_34f2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_34f4, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1016_34f7, 5); calld(Definitions.my_string_dtor, -0x2_19d2); /* call 0x10141b2a */
            ii(0x1016_34fc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_34fe, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_34ff, 1); popd(edi);                              /* pop edi */
            ii(0x1016_3500, 1); popd(esi);                              /* pop esi */
            ii(0x1016_3501, 1); popd(edx);                              /* pop edx */
            ii(0x1016_3502, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_3503, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_3504, 1); retd(); return;                         /* ret */
        }
    }
}