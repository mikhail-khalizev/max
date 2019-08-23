using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_33a4-d49f5c62")]
        public void Method_100b_33a4()
        {
            ii(0x100b_33a4, 5); push(0x7c);                             /* push 0x7c */
            ii(0x100b_33a9, 5); call(Definitions.sys_check_available_stack_size, 0xb_29a4); /* call 0x10165d52 */
            ii(0x100b_33ae, 1); push(ebx);                              /* push ebx */
            ii(0x100b_33af, 1); push(ecx);                              /* push ecx */
            ii(0x100b_33b0, 1); push(edx);                              /* push edx */
            ii(0x100b_33b1, 1); push(esi);                              /* push esi */
            ii(0x100b_33b2, 1); push(edi);                              /* push edi */
            ii(0x100b_33b3, 1); push(ebp);                              /* push ebp */
            ii(0x100b_33b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_33b6, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x100b_33bc, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_33bf, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100b_33c1, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_33c4, 3); mov(ebx, memd[ds, edx + 0x1e]);         /* mov ebx, [edx+0x1e] */
            ii(0x100b_33c7, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x100b_33ca, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_33cd, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_33d0, 5); call(0x1007_65d0, -0x3_ce05);           /* call 0x100765d0 */
            ii(0x100b_33d5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_33d7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_33da, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x100b_33dd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_33e0, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x100b_33e6, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100b_33eb, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100b_33ed, 5); call(0x100c_1fd4, 0xebe2);              /* call 0x100c1fd4 */
            ii(0x100b_33f2, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_33f5, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100b_33fa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_33fd, 1); push(eax);                              /* push eax */
            ii(0x100b_33fe, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x100b_3404, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100b_3407, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_3409, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_340b, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_340e, 5); call(0x1008_b148, -0x2_82cb);           /* call 0x1008b148 */
            ii(0x100b_3413, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3416, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3419, 5); call(0x1007_6574, -0x3_ceaa);           /* call 0x10076574 */
            ii(0x100b_341e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_3420, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_3422, 3); mov(al, memb[ds, edx + 0x4d]);          /* mov al, [edx+0x4d] */
            ii(0x100b_3425, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_3428, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x100b_342c, 5); call(0x1008_a6d4, -0x2_8d5d);           /* call 0x1008a6d4 */
            ii(0x100b_3431, 1); cwde();                                 /* cwde */
            ii(0x100b_3432, 1); push(eax);                              /* push eax */
            ii(0x100b_3433, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100b_3435, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100b_343a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_343d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3440, 5); call(0x1007_65d0, -0x3_ce75);           /* call 0x100765d0 */
            ii(0x100b_3445, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_3447, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_344a, 5); call(0x1011_fec1, 0x6_ca72);            /* call 0x1011fec1 */
            ii(0x100b_344f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_3452, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100b_3456, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_345d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3460, 4); cmp(memb[ds, eax + 0x21], 0x3);         /* cmp byte [eax+0x21], 0x3 */
            ii(0x100b_3464, 2); if(jnz(0x100b_346d, 0x7)) goto l_0x100b_346d; /* jnz 0x100b346d */
            ii(0x100b_3466, 7); mov(memd[ss, ebp - 0x10], 0x1);         /* mov dword [ebp-0x10], 0x1 */
        l_0x100b_346d:
            ii(0x100b_346d, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100b_3471, 2); if(jnz(0x100b_348a, 0x17)) goto l_0x100b_348a; /* jnz 0x100b348a */
            ii(0x100b_3473, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3476, 5); call(0x100b_375b, 0x2e0);               /* call 0x100b375b */
            ii(0x100b_347b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_347d, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_3480, 5); call(Definitions.my_dtor_d1, -0x2_a789); /* call 0x10088cfc */
            ii(0x100b_3485, 5); jmp(0x100b_36f7, 0x26d); goto l_0x100b_36f7; /* jmp 0x100b36f7 */
        l_0x100b_348a:
            ii(0x100b_348a, 5); call(0x1014_82f4, 0x9_4e65);            /* call 0x101482f4 */
            ii(0x100b_348f, 6); sub(eax, memd[ds, 0x101c_3974]);        /* sub eax, [0x101c3974] */
            ii(0x100b_3495, 6); cmp(eax, memd[ds, 0x101b_dd84]);        /* cmp eax, [0x101bdd84] */
            ii(0x100b_349b, 2); if(jb(0x100b_34aa, 0xd)) goto l_0x100b_34aa; /* jb 0x100b34aa */
            ii(0x100b_349d, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100b_34a1, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x100b_34a4, 6); if(jge(0x100b_36e0, 0x236)) goto l_0x100b_36e0; /* jge 0x100b36e0 */
        l_0x100b_34aa:
            ii(0x100b_34aa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_34ad, 4); inc(memw[ds, eax + 0x1f]);              /* inc word [eax+0x1f] */
            ii(0x100b_34b1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_34b4, 4); mov(dx, memw[ds, eax + 0x1f]);          /* mov dx, [eax+0x1f] */
            ii(0x100b_34b8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_34bb, 4); cmp(dx, memw[ds, eax + 0x17]);          /* cmp dx, [eax+0x17] */
            ii(0x100b_34bf, 6); if(jl(0x100b_356f, 0xaa)) goto l_0x100b_356f; /* jl 0x100b356f */
            ii(0x100b_34c5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_34c8, 5); add(memw[ds, eax + 0x1d], 0x2);         /* add word [eax+0x1d], 0x2 */
            ii(0x100b_34cd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_34d0, 3); mov(eax, memd[ds, eax + 0x1b]);         /* mov eax, [eax+0x1b] */
            ii(0x100b_34d3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_34d6, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100b_34d9, 6); if(jl(0x100b_3566, 0x87)) goto l_0x100b_3566; /* jl 0x100b3566 */
            ii(0x100b_34df, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_34e2, 5); add(memw[ds, eax + 0x17], 0x2);         /* add word [eax+0x17], 0x2 */
            ii(0x100b_34e7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_34ea, 4); cmp(memb[ds, eax + 0x22], 0);           /* cmp byte [eax+0x22], 0x0 */
            ii(0x100b_34ee, 2); if(jz(0x100b_3517, 0x27)) goto l_0x100b_3517; /* jz 0x100b3517 */
            ii(0x100b_34f0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_34f3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_34f6, 5); call(0x1007_6574, -0x3_cf87);           /* call 0x10076574 */
            ii(0x100b_34fb, 5); call(0x1007_623c, -0x3_d2c4);           /* call 0x1007623c */
            ii(0x100b_3500, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x100b_3503, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_3506, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100b_3508, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_350a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_350d, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x100b_3510, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_3513, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100b_3515, 2); if(jle(0x100b_3548, 0x31)) goto l_0x100b_3548; /* jle 0x100b3548 */
        l_0x100b_3517:
            ii(0x100b_3517, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100b_351c, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_3521, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3524, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3527, 5); call(0x1007_6574, -0x3_cfb8);           /* call 0x10076574 */
            ii(0x100b_352c, 5); call(0x100a_b120, -0x8411);             /* call 0x100ab120 */
            ii(0x100b_3531, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3534, 5); call(0x100b_375b, 0x222);               /* call 0x100b375b */
            ii(0x100b_3539, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_353b, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_353e, 5); call(Definitions.my_dtor_d1, -0x2_a847); /* call 0x10088cfc */
            ii(0x100b_3543, 5); jmp(0x100b_36f7, 0x1af); goto l_0x100b_36f7; /* jmp 0x100b36f7 */
        l_0x100b_3548:
            ii(0x100b_3548, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_354b, 4); dec(memw[ds, eax + 0x19]);              /* dec word [eax+0x19] */
            ii(0x100b_354f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3552, 4); inc(memw[ds, eax + 0x1b]);              /* inc word [eax+0x1b] */
            ii(0x100b_3556, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3559, 6); mov(memw[ds, eax + 0x1d], 0);           /* mov word [eax+0x1d], 0x0 */
            ii(0x100b_355f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3562, 4); mov(memb[ds, eax + 0x22], 0);           /* mov byte [eax+0x22], 0x0 */
        l_0x100b_3566:
            ii(0x100b_3566, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3569, 6); mov(memw[ds, eax + 0x1f], 0);           /* mov word [eax+0x1f], 0x0 */
        l_0x100b_356f:
            ii(0x100b_356f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3572, 3); mov(eax, memd[ds, eax + 0x1b]);         /* mov eax, [eax+0x1b] */
            ii(0x100b_3575, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_3578, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_357b, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x100b_3580, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100b_3582, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3585, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_3588, 5); call(0x1008_b1a4, -0x2_83e9);           /* call 0x1008b1a4 */
            ii(0x100b_358d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_3590, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
            ii(0x100b_3593, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_3596, 3); add(edx, 0x19);                         /* add edx, 0x19 */
            ii(0x100b_3599, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_359c, 5); call(0x1010_82ce, 0x5_4d2d);            /* call 0x101082ce */
            ii(0x100b_35a1, 2); test(al, al);                           /* test al, al */
            ii(0x100b_35a3, 6); if(jz(0x100b_36db, 0x132)) goto l_0x100b_36db; /* jz 0x100b36db */
            ii(0x100b_35a9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_35ac, 4); mov(memb[ds, eax + 0x22], 0x1);         /* mov byte [eax+0x22], 0x1 */
            ii(0x100b_35b0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_35b3, 3); mov(eax, memd[ds, eax + 0x17]);         /* mov eax, [eax+0x17] */
            ii(0x100b_35b6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_35b9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_35bc, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x100b_35bf, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100b_35c1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_35c4, 3); mov(eax, memd[ds, eax + 0x19]);         /* mov eax, [eax+0x19] */
            ii(0x100b_35c7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_35ca, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100b_35cc, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100b_35ce, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_35d0, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100b_35d3, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100b_35d7, 2); if(jge(0x100b_3615, 0x3c)) goto l_0x100b_3615; /* jge 0x100b3615 */
            ii(0x100b_35d9, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100b_35de, 1); push(eax);                              /* push eax */
            ii(0x100b_35df, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_35e2, 3); mov(ecx, memd[ds, eax + 0x19]);         /* mov ecx, [eax+0x19] */
            ii(0x100b_35e5, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100b_35e8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_35eb, 3); mov(ebx, memd[ds, eax + 0x17]);         /* mov ebx, [eax+0x17] */
            ii(0x100b_35ee, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_35f1, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_35f4, 3); mov(edx, memd[ds, edx + 0x7]);          /* mov edx, [edx+0x7] */
            ii(0x100b_35f7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_35fa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_35fd, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3600, 5); call(0x1007_6574, -0x3_d091);           /* call 0x10076574 */
            ii(0x100b_3605, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100b_3608, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_360b, 5); call(0x1007_02b9, -0x4_3357);           /* call 0x100702b9 */
            ii(0x100b_3610, 1); cwde();                                 /* cwde */
            ii(0x100b_3611, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_3613, 2); if(jnz(0x100b_3617, 0x2)) goto l_0x100b_3617; /* jnz 0x100b3617 */
        l_0x100b_3615:
            ii(0x100b_3615, 2); jmp(0x100b_3633, 0x1c); goto l_0x100b_3633; /* jmp 0x100b3633 */
        l_0x100b_3617:
            ii(0x100b_3617, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_361a, 3); add(edx, 0x19);                         /* add edx, 0x19 */
            ii(0x100b_361d, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_3620, 5); call(0x1007_5e64, -0x3_d7c1);           /* call 0x10075e64 */
            ii(0x100b_3625, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_3627, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_362a, 5); call(0x1011_ff4c, 0x6_c91d);            /* call 0x1011ff4c */
            ii(0x100b_362f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3631, 2); if(jnz(0x100b_3638, 0x5)) goto l_0x100b_3638; /* jnz 0x100b3638 */
        l_0x100b_3633:
            ii(0x100b_3633, 5); jmp(0x100b_36db, 0xa3); goto l_0x100b_36db; /* jmp 0x100b36db */
        l_0x100b_3638:
            ii(0x100b_3638, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100b_363d, 5); call(Definitions.sys_new, 0xb_27be);    /* call 0x10165e00 */
            ii(0x100b_3642, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100b_3645, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100b_3648, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100b_364b, 4); cmp(memd[ss, ebp - 0x44], 0);           /* cmp dword [ebp-0x44], 0x0 */
            ii(0x100b_364f, 2); if(jz(0x100b_368e, 0x3d)) goto l_0x100b_368e; /* jz 0x100b368e */
            ii(0x100b_3651, 5); mov(eax, 0x100b_3700);                  /* mov eax, 0x100b3700 */
            ii(0x100b_3656, 1); push(eax);                              /* push eax */
            ii(0x100b_3657, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_365a, 3); add(edx, 0x19);                         /* add edx, 0x19 */
            ii(0x100b_365d, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_3660, 5); call(0x1007_5e64, -0x3_d801);           /* call 0x10075e64 */
            ii(0x100b_3665, 1); push(eax);                              /* push eax */
            ii(0x100b_3666, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_3668, 1); push(eax);                              /* push eax */
            ii(0x100b_3669, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100b_366b, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x100b_366e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3671, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3674, 5); call(0x1007_65d0, -0x3_d0a9);           /* call 0x100765d0 */
            ii(0x100b_3679, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_367b, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100b_367e, 5); call(0x100a_c220, -0x7463);             /* call 0x100ac220 */
            ii(0x100b_3683, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100b_3686, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100b_3689, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x100b_368c, 2); jmp(0x100b_3694, 0x6); goto l_0x100b_3694; /* jmp 0x100b3694 */
        l_0x100b_368e:
            ii(0x100b_368e, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x100b_3691, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
        l_0x100b_3694:
            ii(0x100b_3694, 3); mov(edx, memd[ss, ebp - 0x50]);         /* mov edx, [ebp-0x50] */
            ii(0x100b_3697, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100b_369a, 5); call(0x1008_a5f0, -0x2_90af);           /* call 0x1008a5f0 */
            ii(0x100b_369f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_36a4, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100b_36a7, 5); call(0x1008_a520, -0x2_918c);           /* call 0x1008a520 */
            ii(0x100b_36ac, 5); call(0x1008_a6a4, -0x2_900d);           /* call 0x1008a6a4 */
            ii(0x100b_36b1, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100b_36b4, 5); call(0x1008_a57c, -0x2_913d);           /* call 0x1008a57c */
            ii(0x100b_36b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_36bb, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_36c0, 5); call(0x100a_4d50, -0xe975);             /* call 0x100a4d50 */
            ii(0x100b_36c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_36c7, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100b_36ca, 5); call(0x1008_8d4c, -0x2_a983);           /* call 0x10088d4c */
            ii(0x100b_36cf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_36d1, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_36d4, 5); call(Definitions.my_dtor_d1, -0x2_a9dd); /* call 0x10088cfc */
            ii(0x100b_36d9, 2); jmp(0x100b_36f7, 0x1c); goto l_0x100b_36f7; /* jmp 0x100b36f7 */
        l_0x100b_36db:
            ii(0x100b_36db, 5); jmp(0x100b_348a, -0x256); goto l_0x100b_348a; /* jmp 0x100b348a */
        l_0x100b_36e0:
            ii(0x100b_36e0, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_36e5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_36e8, 5); call(0x100a_28ff, -0x1_0dee);           /* call 0x100a28ff */
            ii(0x100b_36ed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_36ef, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_36f2, 5); call(Definitions.my_dtor_d1, -0x2_a9fb); /* call 0x10088cfc */
        l_0x100b_36f7:
            ii(0x100b_36f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_36f9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_36fa, 1); pop(edi);                               /* pop edi */
            ii(0x100b_36fb, 1); pop(esi);                               /* pop esi */
            ii(0x100b_36fc, 1); pop(edx);                               /* pop edx */
            ii(0x100b_36fd, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_36fe, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_36ff, 1); ret();                                  /* ret */
        }
    }
}
