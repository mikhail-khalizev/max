using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a9d674bf-f80f-4085-9631-61f8dc71520b")]
        public void Method_100d_3395()
        {
            ii(0x100d_3395, 5); pushd(0x214);                           /* push 0x214 */
            ii(0x100d_339a, 5); calld(Definitions.sys_check_available_stack_size, 0x9_29b3); /* call 0x10165d52 */
            ii(0x100d_339f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_33a0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_33a1, 1); pushd(esi);                             /* push esi */
            ii(0x100d_33a2, 1); pushd(edi);                             /* push edi */
            ii(0x100d_33a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_33a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_33a6, 6); sub(esp, 0x1e4);                        /* sub esp, 0x1e4 */
            ii(0x100d_33ac, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_33af, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_33b2, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100d_33b5, 5); mov(edx, 0x6c7);                        /* mov edx, 0x6c7 */
            ii(0x100d_33ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_33bd, 5); calld(0x100d_0ebd, -0x2505);            /* call 0x100d0ebd */
            ii(0x100d_33c2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_33c5, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100d_33c8, 6); mov(memd_a32[ss, ebp - 0x168], eax);    /* mov [ebp-0x168], eax */
            ii(0x100d_33ce, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100d_33d2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100d_33d7, 6); lea(edx, ebp - 0x164);                  /* lea edx, [ebp-0x164] */
            ii(0x100d_33dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_33e0, 5); calld(0x1015_0a5f, 0x7_d67a);           /* call 0x10150a5f */
            ii(0x100d_33e5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_33e7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_33ea, 5); add(eax, 0x87);                         /* add eax, 0x87 */
            ii(0x100d_33ef, 5); calld(0x1009_cab0, -0x3_6944);          /* call 0x1009cab0 */
            ii(0x100d_33f4, 5); sub(eax, 0x87);                         /* sub eax, 0x87 */
            ii(0x100d_33f9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_33fc, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100d_33ff, 6); mov(memd_a32[ss, ebp - 0x160], eax);    /* mov [ebp-0x160], eax */
            ii(0x100d_3405, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100d_3409, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_340b, 6); lea(eax, ebp - 0x164);                  /* lea eax, [ebp-0x164] */
            ii(0x100d_3411, 5); calld(0x1008_8b04, -0x4_a912);          /* call 0x10088b04 */
            ii(0x100d_3416, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3419, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_5c50); /* mov dword [eax+0x13], 0x101b5c50 */
            ii(0x100d_3420, 6); lea(edx, ebp - 0x158);                  /* lea edx, [ebp-0x158] */
            ii(0x100d_3426, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_3429, 5); calld(0x1015_0a5f, 0x7_d631);           /* call 0x10150a5f */
            ii(0x100d_342e, 5); calld(Definitions.my_2_get_count, -0x4_80cb); /* call 0x1008b368 */
            ii(0x100d_3433, 1); cwde();                                 /* cwde */
            ii(0x100d_3434, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_3436, 2); if(jled(0x100d_3441, 0x9)) goto l_0x100d_3441; /* jle 0x100d3441 */
            ii(0x100d_3438, 7); mov(memd_a32[ss, ebp - 0x40], 0x1);     /* mov dword [ebp-0x40], 0x1 */
            ii(0x100d_343f, 2); jmpd(0x100d_3448, 0x7); goto l_0x100d_3448; /* jmp 0x100d3448 */
        l_0x100d_3441:
            ii(0x100d_3441, 7); mov(memd_a32[ss, ebp - 0x40], 0);       /* mov dword [ebp-0x40], 0x0 */
        l_0x100d_3448:
            ii(0x100d_3448, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100d_344b, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100d_344e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_3450, 6); lea(eax, ebp - 0x158);                  /* lea eax, [ebp-0x158] */
            ii(0x100d_3456, 5); calld(0x1008_8b04, -0x4_a957);          /* call 0x10088b04 */
            ii(0x100d_345b, 4); cmp(memd_a32[ss, ebp - 0x58], 0);       /* cmp dword [ebp-0x58], 0x0 */
            ii(0x100d_345f, 2); if(jzd(0x100d_3477, 0x16)) goto l_0x100d_3477; /* jz 0x100d3477 */
            ii(0x100d_3461, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_3464, 5); calld(0x1015_0a9e, 0x7_d635);           /* call 0x10150a9e */
            ii(0x100d_3469, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_346b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_346e, 7); mov(memw_a32[ds, eax + 0x8b], dx);      /* mov [eax+0x8b], dx */
            ii(0x100d_3475, 2); jmpd(0x100d_3483, 0xc); goto l_0x100d_3483; /* jmp 0x100d3483 */
        l_0x100d_3477:
            ii(0x100d_3477, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_347a, 9); mov(memw_a32[ds, eax + 0x8b], 0xffff);  /* mov word [eax+0x8b], 0xffff */
        l_0x100d_3483:
            ii(0x100d_3483, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_3488, 5); calld(Definitions.sys_new, 0x9_2973);   /* call 0x10165e00 */
            ii(0x100d_348d, 6); mov(memd_a32[ss, ebp - 0x14c], eax);    /* mov [ebp-0x14c], eax */
            ii(0x100d_3493, 6); mov(eax, memd_a32[ss, ebp - 0x14c]);    /* mov eax, [ebp-0x14c] */
            ii(0x100d_3499, 6); mov(memd_a32[ss, ebp - 0x150], eax);    /* mov [ebp-0x150], eax */
            ii(0x100d_349f, 7); cmp(memd_a32[ss, ebp - 0x150], 0);      /* cmp dword [ebp-0x150], 0x0 */
            ii(0x100d_34a6, 2); if(jzd(0x100d_34dc, 0x34)) goto l_0x100d_34dc; /* jz 0x100d34dc */
            ii(0x100d_34a8, 5); mov(eax, 0x1b9);                        /* mov eax, 0x1b9 */
            ii(0x100d_34ad, 1); pushd(eax);                             /* push eax */
            ii(0x100d_34ae, 5); mov(ecx, 0x1d7);                        /* mov ecx, 0x1d7 */
            ii(0x100d_34b3, 5); mov(ebx, 0x11b);                        /* mov ebx, 0x11b */
            ii(0x100d_34b8, 5); mov(edx, 0x11a);                        /* mov edx, 0x11a */
            ii(0x100d_34bd, 6); mov(eax, memd_a32[ss, ebp - 0x14c]);    /* mov eax, [ebp-0x14c] */
            ii(0x100d_34c3, 5); calld(Definitions.my_ctor_c17, -0x50b9); /* call 0x100ce40f */
            ii(0x100d_34c8, 6); mov(memd_a32[ss, ebp - 0x154], eax);    /* mov [ebp-0x154], eax */
            ii(0x100d_34ce, 6); mov(eax, memd_a32[ss, ebp - 0x154]);    /* mov eax, [ebp-0x154] */
            ii(0x100d_34d4, 6); mov(memd_a32[ss, ebp - 0x170], eax);    /* mov [ebp-0x170], eax */
            ii(0x100d_34da, 2); jmpd(0x100d_34e8, 0xc); goto l_0x100d_34e8; /* jmp 0x100d34e8 */
        l_0x100d_34dc:
            ii(0x100d_34dc, 6); mov(eax, memd_a32[ss, ebp - 0x150]);    /* mov eax, [ebp-0x150] */
            ii(0x100d_34e2, 6); mov(memd_a32[ss, ebp - 0x170], eax);    /* mov [ebp-0x170], eax */
        l_0x100d_34e8:
            ii(0x100d_34e8, 6); mov(eax, memd_a32[ss, ebp - 0x170]);    /* mov eax, [ebp-0x170] */
            ii(0x100d_34ee, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_34f1, 3); mov(memd_a32[ds, edx + 0x42], eax);     /* mov [edx+0x42], eax */
            ii(0x100d_34f4, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_34f9, 5); calld(Definitions.sys_new, 0x9_2902);   /* call 0x10165e00 */
            ii(0x100d_34fe, 6); mov(memd_a32[ss, ebp - 0x140], eax);    /* mov [ebp-0x140], eax */
            ii(0x100d_3504, 6); mov(eax, memd_a32[ss, ebp - 0x140]);    /* mov eax, [ebp-0x140] */
            ii(0x100d_350a, 6); mov(memd_a32[ss, ebp - 0x144], eax);    /* mov [ebp-0x144], eax */
            ii(0x100d_3510, 7); cmp(memd_a32[ss, ebp - 0x144], 0);      /* cmp dword [ebp-0x144], 0x0 */
            ii(0x100d_3517, 2); if(jzd(0x100d_354d, 0x34)) goto l_0x100d_354d; /* jz 0x100d354d */
            ii(0x100d_3519, 5); mov(eax, 0x1b9);                        /* mov eax, 0x1b9 */
            ii(0x100d_351e, 1); pushd(eax);                             /* push eax */
            ii(0x100d_351f, 5); mov(ecx, 0x1eb);                        /* mov ecx, 0x1eb */
            ii(0x100d_3524, 5); mov(ebx, 0x11e);                        /* mov ebx, 0x11e */
            ii(0x100d_3529, 5); mov(edx, 0x11d);                        /* mov edx, 0x11d */
            ii(0x100d_352e, 6); mov(eax, memd_a32[ss, ebp - 0x140]);    /* mov eax, [ebp-0x140] */
            ii(0x100d_3534, 5); calld(Definitions.my_ctor_c17, -0x512a); /* call 0x100ce40f */
            ii(0x100d_3539, 6); mov(memd_a32[ss, ebp - 0x148], eax);    /* mov [ebp-0x148], eax */
            ii(0x100d_353f, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x100d_3545, 6); mov(memd_a32[ss, ebp - 0x174], eax);    /* mov [ebp-0x174], eax */
            ii(0x100d_354b, 2); jmpd(0x100d_3559, 0xc); goto l_0x100d_3559; /* jmp 0x100d3559 */
        l_0x100d_354d:
            ii(0x100d_354d, 6); mov(eax, memd_a32[ss, ebp - 0x144]);    /* mov eax, [ebp-0x144] */
            ii(0x100d_3553, 6); mov(memd_a32[ss, ebp - 0x174], eax);    /* mov [ebp-0x174], eax */
        l_0x100d_3559:
            ii(0x100d_3559, 6); mov(eax, memd_a32[ss, ebp - 0x174]);    /* mov eax, [ebp-0x174] */
            ii(0x100d_355f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3562, 3); mov(memd_a32[ds, edx + 0x46], eax);     /* mov [edx+0x46], eax */
            ii(0x100d_3565, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_356a, 5); calld(Definitions.sys_new, 0x9_2891);   /* call 0x10165e00 */
            ii(0x100d_356f, 6); mov(memd_a32[ss, ebp - 0x134], eax);    /* mov [ebp-0x134], eax */
            ii(0x100d_3575, 6); mov(eax, memd_a32[ss, ebp - 0x134]);    /* mov eax, [ebp-0x134] */
            ii(0x100d_357b, 6); mov(memd_a32[ss, ebp - 0x138], eax);    /* mov [ebp-0x138], eax */
            ii(0x100d_3581, 7); cmp(memd_a32[ss, ebp - 0x138], 0);      /* cmp dword [ebp-0x138], 0x0 */
            ii(0x100d_3588, 2); if(jzd(0x100d_35be, 0x34)) goto l_0x100d_35be; /* jz 0x100d35be */
            ii(0x100d_358a, 5); mov(eax, 0x108);                        /* mov eax, 0x108 */
            ii(0x100d_358f, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3590, 5); mov(ecx, 0x124);                        /* mov ecx, 0x124 */
            ii(0x100d_3595, 5); mov(ebx, 0x129);                        /* mov ebx, 0x129 */
            ii(0x100d_359a, 5); mov(edx, 0x128);                        /* mov edx, 0x128 */
            ii(0x100d_359f, 6); mov(eax, memd_a32[ss, ebp - 0x134]);    /* mov eax, [ebp-0x134] */
            ii(0x100d_35a5, 5); calld(Definitions.my_ctor_c17, -0x519b); /* call 0x100ce40f */
            ii(0x100d_35aa, 6); mov(memd_a32[ss, ebp - 0x13c], eax);    /* mov [ebp-0x13c], eax */
            ii(0x100d_35b0, 6); mov(eax, memd_a32[ss, ebp - 0x13c]);    /* mov eax, [ebp-0x13c] */
            ii(0x100d_35b6, 6); mov(memd_a32[ss, ebp - 0x178], eax);    /* mov [ebp-0x178], eax */
            ii(0x100d_35bc, 2); jmpd(0x100d_35ca, 0xc); goto l_0x100d_35ca; /* jmp 0x100d35ca */
        l_0x100d_35be:
            ii(0x100d_35be, 6); mov(eax, memd_a32[ss, ebp - 0x138]);    /* mov eax, [ebp-0x138] */
            ii(0x100d_35c4, 6); mov(memd_a32[ss, ebp - 0x178], eax);    /* mov [ebp-0x178], eax */
        l_0x100d_35ca:
            ii(0x100d_35ca, 6); mov(eax, memd_a32[ss, ebp - 0x178]);    /* mov eax, [ebp-0x178] */
            ii(0x100d_35d0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_35d3, 3); mov(memd_a32[ds, edx + 0x4a], eax);     /* mov [edx+0x4a], eax */
            ii(0x100d_35d6, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_35db, 5); calld(Definitions.sys_new, 0x9_2820);   /* call 0x10165e00 */
            ii(0x100d_35e0, 6); mov(memd_a32[ss, ebp - 0x128], eax);    /* mov [ebp-0x128], eax */
            ii(0x100d_35e6, 6); mov(eax, memd_a32[ss, ebp - 0x128]);    /* mov eax, [ebp-0x128] */
            ii(0x100d_35ec, 6); mov(memd_a32[ss, ebp - 0x12c], eax);    /* mov [ebp-0x12c], eax */
            ii(0x100d_35f2, 7); cmp(memd_a32[ss, ebp - 0x12c], 0);      /* cmp dword [ebp-0x12c], 0x0 */
            ii(0x100d_35f9, 2); if(jzd(0x100d_362f, 0x34)) goto l_0x100d_362f; /* jz 0x100d362f */
            ii(0x100d_35fb, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_3600, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3601, 5); mov(ecx, 0x18d);                        /* mov ecx, 0x18d */
            ii(0x100d_3606, 5); mov(ebx, 0x123);                        /* mov ebx, 0x123 */
            ii(0x100d_360b, 5); mov(edx, 0x122);                        /* mov edx, 0x122 */
            ii(0x100d_3610, 6); mov(eax, memd_a32[ss, ebp - 0x128]);    /* mov eax, [ebp-0x128] */
            ii(0x100d_3616, 5); calld(Definitions.my_ctor_c17, -0x520c); /* call 0x100ce40f */
            ii(0x100d_361b, 6); mov(memd_a32[ss, ebp - 0x130], eax);    /* mov [ebp-0x130], eax */
            ii(0x100d_3621, 6); mov(eax, memd_a32[ss, ebp - 0x130]);    /* mov eax, [ebp-0x130] */
            ii(0x100d_3627, 6); mov(memd_a32[ss, ebp - 0x17c], eax);    /* mov [ebp-0x17c], eax */
            ii(0x100d_362d, 2); jmpd(0x100d_363b, 0xc); goto l_0x100d_363b; /* jmp 0x100d363b */
        l_0x100d_362f:
            ii(0x100d_362f, 6); mov(eax, memd_a32[ss, ebp - 0x12c]);    /* mov eax, [ebp-0x12c] */
            ii(0x100d_3635, 6); mov(memd_a32[ss, ebp - 0x17c], eax);    /* mov [ebp-0x17c], eax */
        l_0x100d_363b:
            ii(0x100d_363b, 6); mov(eax, memd_a32[ss, ebp - 0x17c]);    /* mov eax, [ebp-0x17c] */
            ii(0x100d_3641, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3644, 3); mov(memd_a32[ds, edx + 0x4e], eax);     /* mov [edx+0x4e], eax */
            ii(0x100d_3647, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_364c, 5); calld(Definitions.sys_new, 0x9_27af);   /* call 0x10165e00 */
            ii(0x100d_3651, 6); mov(memd_a32[ss, ebp - 0x11c], eax);    /* mov [ebp-0x11c], eax */
            ii(0x100d_3657, 6); mov(eax, memd_a32[ss, ebp - 0x11c]);    /* mov eax, [ebp-0x11c] */
            ii(0x100d_365d, 6); mov(memd_a32[ss, ebp - 0x120], eax);    /* mov [ebp-0x120], eax */
            ii(0x100d_3663, 7); cmp(memd_a32[ss, ebp - 0x120], 0);      /* cmp dword [ebp-0x120], 0x0 */
            ii(0x100d_366a, 2); if(jzd(0x100d_36a0, 0x34)) goto l_0x100d_36a0; /* jz 0x100d36a0 */
            ii(0x100d_366c, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_3671, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3672, 5); mov(ecx, 0x172);                        /* mov ecx, 0x172 */
            ii(0x100d_3677, 5); mov(ebx, 0x12d);                        /* mov ebx, 0x12d */
            ii(0x100d_367c, 5); mov(edx, 0x12c);                        /* mov edx, 0x12c */
            ii(0x100d_3681, 6); mov(eax, memd_a32[ss, ebp - 0x11c]);    /* mov eax, [ebp-0x11c] */
            ii(0x100d_3687, 5); calld(Definitions.my_ctor_c17, -0x527d); /* call 0x100ce40f */
            ii(0x100d_368c, 6); mov(memd_a32[ss, ebp - 0x124], eax);    /* mov [ebp-0x124], eax */
            ii(0x100d_3692, 6); mov(eax, memd_a32[ss, ebp - 0x124]);    /* mov eax, [ebp-0x124] */
            ii(0x100d_3698, 6); mov(memd_a32[ss, ebp - 0x180], eax);    /* mov [ebp-0x180], eax */
            ii(0x100d_369e, 2); jmpd(0x100d_36ac, 0xc); goto l_0x100d_36ac; /* jmp 0x100d36ac */
        l_0x100d_36a0:
            ii(0x100d_36a0, 6); mov(eax, memd_a32[ss, ebp - 0x120]);    /* mov eax, [ebp-0x120] */
            ii(0x100d_36a6, 6); mov(memd_a32[ss, ebp - 0x180], eax);    /* mov [ebp-0x180], eax */
        l_0x100d_36ac:
            ii(0x100d_36ac, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x100d_36b2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_36b5, 3); mov(memd_a32[ds, edx + 0x52], eax);     /* mov [edx+0x52], eax */
            ii(0x100d_36b8, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_36bd, 5); calld(Definitions.sys_new, 0x9_273e);   /* call 0x10165e00 */
            ii(0x100d_36c2, 6); mov(memd_a32[ss, ebp - 0x110], eax);    /* mov [ebp-0x110], eax */
            ii(0x100d_36c8, 6); mov(eax, memd_a32[ss, ebp - 0x110]);    /* mov eax, [ebp-0x110] */
            ii(0x100d_36ce, 6); mov(memd_a32[ss, ebp - 0x114], eax);    /* mov [ebp-0x114], eax */
            ii(0x100d_36d4, 7); cmp(memd_a32[ss, ebp - 0x114], 0);      /* cmp dword [ebp-0x114], 0x0 */
            ii(0x100d_36db, 2); if(jzd(0x100d_3711, 0x34)) goto l_0x100d_3711; /* jz 0x100d3711 */
            ii(0x100d_36dd, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_36e2, 1); pushd(eax);                             /* push eax */
            ii(0x100d_36e3, 5); mov(ecx, 0x133);                        /* mov ecx, 0x133 */
            ii(0x100d_36e8, 5); mov(ebx, 0x12b);                        /* mov ebx, 0x12b */
            ii(0x100d_36ed, 5); mov(edx, 0x12a);                        /* mov edx, 0x12a */
            ii(0x100d_36f2, 6); mov(eax, memd_a32[ss, ebp - 0x110]);    /* mov eax, [ebp-0x110] */
            ii(0x100d_36f8, 5); calld(Definitions.my_ctor_c17, -0x52ee); /* call 0x100ce40f */
            ii(0x100d_36fd, 6); mov(memd_a32[ss, ebp - 0x118], eax);    /* mov [ebp-0x118], eax */
            ii(0x100d_3703, 6); mov(eax, memd_a32[ss, ebp - 0x118]);    /* mov eax, [ebp-0x118] */
            ii(0x100d_3709, 6); mov(memd_a32[ss, ebp - 0x184], eax);    /* mov [ebp-0x184], eax */
            ii(0x100d_370f, 2); jmpd(0x100d_371d, 0xc); goto l_0x100d_371d; /* jmp 0x100d371d */
        l_0x100d_3711:
            ii(0x100d_3711, 6); mov(eax, memd_a32[ss, ebp - 0x114]);    /* mov eax, [ebp-0x114] */
            ii(0x100d_3717, 6); mov(memd_a32[ss, ebp - 0x184], eax);    /* mov [ebp-0x184], eax */
        l_0x100d_371d:
            ii(0x100d_371d, 6); mov(eax, memd_a32[ss, ebp - 0x184]);    /* mov eax, [ebp-0x184] */
            ii(0x100d_3723, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3726, 3); mov(memd_a32[ds, edx + 0x56], eax);     /* mov [edx+0x56], eax */
            ii(0x100d_3729, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_372e, 5); calld(Definitions.sys_new, 0x9_26cd);   /* call 0x10165e00 */
            ii(0x100d_3733, 6); mov(memd_a32[ss, ebp - 0x104], eax);    /* mov [ebp-0x104], eax */
            ii(0x100d_3739, 6); mov(eax, memd_a32[ss, ebp - 0x104]);    /* mov eax, [ebp-0x104] */
            ii(0x100d_373f, 6); mov(memd_a32[ss, ebp - 0x108], eax);    /* mov [ebp-0x108], eax */
            ii(0x100d_3745, 7); cmp(memd_a32[ss, ebp - 0x108], 0);      /* cmp dword [ebp-0x108], 0x0 */
            ii(0x100d_374c, 2); if(jzd(0x100d_3782, 0x34)) goto l_0x100d_3782; /* jz 0x100d3782 */
            ii(0x100d_374e, 5); mov(eax, 0x125);                        /* mov eax, 0x125 */
            ii(0x100d_3753, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3754, 5); mov(ecx, 0x147);                        /* mov ecx, 0x147 */
            ii(0x100d_3759, 5); mov(ebx, 0x11b);                        /* mov ebx, 0x11b */
            ii(0x100d_375e, 5); mov(edx, 0x11a);                        /* mov edx, 0x11a */
            ii(0x100d_3763, 6); mov(eax, memd_a32[ss, ebp - 0x104]);    /* mov eax, [ebp-0x104] */
            ii(0x100d_3769, 5); calld(Definitions.my_ctor_c17, -0x535f); /* call 0x100ce40f */
            ii(0x100d_376e, 6); mov(memd_a32[ss, ebp - 0x10c], eax);    /* mov [ebp-0x10c], eax */
            ii(0x100d_3774, 6); mov(eax, memd_a32[ss, ebp - 0x10c]);    /* mov eax, [ebp-0x10c] */
            ii(0x100d_377a, 6); mov(memd_a32[ss, ebp - 0x188], eax);    /* mov [ebp-0x188], eax */
            ii(0x100d_3780, 2); jmpd(0x100d_378e, 0xc); goto l_0x100d_378e; /* jmp 0x100d378e */
        l_0x100d_3782:
            ii(0x100d_3782, 6); mov(eax, memd_a32[ss, ebp - 0x108]);    /* mov eax, [ebp-0x108] */
            ii(0x100d_3788, 6); mov(memd_a32[ss, ebp - 0x188], eax);    /* mov [ebp-0x188], eax */
        l_0x100d_378e:
            ii(0x100d_378e, 6); mov(eax, memd_a32[ss, ebp - 0x188]);    /* mov eax, [ebp-0x188] */
            ii(0x100d_3794, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3797, 6); mov(memd_a32[ds, edx + 0x95], eax);     /* mov [edx+0x95], eax */
            ii(0x100d_379d, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_37a2, 5); calld(Definitions.sys_new, 0x9_2659);   /* call 0x10165e00 */
            ii(0x100d_37a7, 6); mov(memd_a32[ss, ebp - 0xf8], eax);     /* mov [ebp-0xf8], eax */
            ii(0x100d_37ad, 6); mov(eax, memd_a32[ss, ebp - 0xf8]);     /* mov eax, [ebp-0xf8] */
            ii(0x100d_37b3, 6); mov(memd_a32[ss, ebp - 0xfc], eax);     /* mov [ebp-0xfc], eax */
            ii(0x100d_37b9, 7); cmp(memd_a32[ss, ebp - 0xfc], 0);       /* cmp dword [ebp-0xfc], 0x0 */
            ii(0x100d_37c0, 2); if(jzd(0x100d_37f6, 0x34)) goto l_0x100d_37f6; /* jz 0x100d37f6 */
            ii(0x100d_37c2, 5); mov(eax, 0x125);                        /* mov eax, 0x125 */
            ii(0x100d_37c7, 1); pushd(eax);                             /* push eax */
            ii(0x100d_37c8, 5); mov(ecx, 0x15b);                        /* mov ecx, 0x15b */
            ii(0x100d_37cd, 5); mov(ebx, 0x11e);                        /* mov ebx, 0x11e */
            ii(0x100d_37d2, 5); mov(edx, 0x11d);                        /* mov edx, 0x11d */
            ii(0x100d_37d7, 6); mov(eax, memd_a32[ss, ebp - 0xf8]);     /* mov eax, [ebp-0xf8] */
            ii(0x100d_37dd, 5); calld(Definitions.my_ctor_c17, -0x53d3); /* call 0x100ce40f */
            ii(0x100d_37e2, 6); mov(memd_a32[ss, ebp - 0x100], eax);    /* mov [ebp-0x100], eax */
            ii(0x100d_37e8, 6); mov(eax, memd_a32[ss, ebp - 0x100]);    /* mov eax, [ebp-0x100] */
            ii(0x100d_37ee, 6); mov(memd_a32[ss, ebp - 0x18c], eax);    /* mov [ebp-0x18c], eax */
            ii(0x100d_37f4, 2); jmpd(0x100d_3802, 0xc); goto l_0x100d_3802; /* jmp 0x100d3802 */
        l_0x100d_37f6:
            ii(0x100d_37f6, 6); mov(eax, memd_a32[ss, ebp - 0xfc]);     /* mov eax, [ebp-0xfc] */
            ii(0x100d_37fc, 6); mov(memd_a32[ss, ebp - 0x18c], eax);    /* mov [ebp-0x18c], eax */
        l_0x100d_3802:
            ii(0x100d_3802, 6); mov(eax, memd_a32[ss, ebp - 0x18c]);    /* mov eax, [ebp-0x18c] */
            ii(0x100d_3808, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_380b, 6); mov(memd_a32[ds, edx + 0x99], eax);     /* mov [edx+0x99], eax */
            ii(0x100d_3811, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_3816, 5); calld(Definitions.sys_new, 0x9_25e5);   /* call 0x10165e00 */
            ii(0x100d_381b, 6); mov(memd_a32[ss, ebp - 0xec], eax);     /* mov [ebp-0xec], eax */
            ii(0x100d_3821, 6); mov(eax, memd_a32[ss, ebp - 0xec]);     /* mov eax, [ebp-0xec] */
            ii(0x100d_3827, 6); mov(memd_a32[ss, ebp - 0xf0], eax);     /* mov [ebp-0xf0], eax */
            ii(0x100d_382d, 7); cmp(memd_a32[ss, ebp - 0xf0], 0);       /* cmp dword [ebp-0xf0], 0x0 */
            ii(0x100d_3834, 2); if(jzd(0x100d_386a, 0x34)) goto l_0x100d_386a; /* jz 0x100d386a */
            ii(0x100d_3836, 5); mov(eax, 0x173);                        /* mov eax, 0x173 */
            ii(0x100d_383b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_383c, 5); mov(ecx, 0x124);                        /* mov ecx, 0x124 */
            ii(0x100d_3841, 5); mov(ebx, 0x121);                        /* mov ebx, 0x121 */
            ii(0x100d_3846, 5); mov(edx, 0x120);                        /* mov edx, 0x120 */
            ii(0x100d_384b, 6); mov(eax, memd_a32[ss, ebp - 0xec]);     /* mov eax, [ebp-0xec] */
            ii(0x100d_3851, 5); calld(Definitions.my_ctor_c17, -0x5447); /* call 0x100ce40f */
            ii(0x100d_3856, 6); mov(memd_a32[ss, ebp - 0xf4], eax);     /* mov [ebp-0xf4], eax */
            ii(0x100d_385c, 6); mov(eax, memd_a32[ss, ebp - 0xf4]);     /* mov eax, [ebp-0xf4] */
            ii(0x100d_3862, 6); mov(memd_a32[ss, ebp - 0x190], eax);    /* mov [ebp-0x190], eax */
            ii(0x100d_3868, 2); jmpd(0x100d_3876, 0xc); goto l_0x100d_3876; /* jmp 0x100d3876 */
        l_0x100d_386a:
            ii(0x100d_386a, 6); mov(eax, memd_a32[ss, ebp - 0xf0]);     /* mov eax, [ebp-0xf0] */
            ii(0x100d_3870, 6); mov(memd_a32[ss, ebp - 0x190], eax);    /* mov [ebp-0x190], eax */
        l_0x100d_3876:
            ii(0x100d_3876, 6); mov(eax, memd_a32[ss, ebp - 0x190]);    /* mov eax, [ebp-0x190] */
            ii(0x100d_387c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_387f, 3); mov(memd_a32[ds, edx + 0x5e], eax);     /* mov [edx+0x5e], eax */
            ii(0x100d_3882, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_3887, 5); calld(Definitions.sys_new, 0x9_2574);   /* call 0x10165e00 */
            ii(0x100d_388c, 6); mov(memd_a32[ss, ebp - 0xe0], eax);     /* mov [ebp-0xe0], eax */
            ii(0x100d_3892, 6); mov(eax, memd_a32[ss, ebp - 0xe0]);     /* mov eax, [ebp-0xe0] */
            ii(0x100d_3898, 6); mov(memd_a32[ss, ebp - 0xe4], eax);     /* mov [ebp-0xe4], eax */
            ii(0x100d_389e, 7); cmp(memd_a32[ss, ebp - 0xe4], 0);       /* cmp dword [ebp-0xe4], 0x0 */
            ii(0x100d_38a5, 2); if(jzd(0x100d_38db, 0x34)) goto l_0x100d_38db; /* jz 0x100d38db */
            ii(0x100d_38a7, 5); mov(eax, 0x18c);                        /* mov eax, 0x18c */
            ii(0x100d_38ac, 1); pushd(eax);                             /* push eax */
            ii(0x100d_38ad, 5); mov(ecx, 0x124);                        /* mov ecx, 0x124 */
            ii(0x100d_38b2, 5); mov(ebx, 0x131);                        /* mov ebx, 0x131 */
            ii(0x100d_38b7, 5); mov(edx, 0x130);                        /* mov edx, 0x130 */
            ii(0x100d_38bc, 6); mov(eax, memd_a32[ss, ebp - 0xe0]);     /* mov eax, [ebp-0xe0] */
            ii(0x100d_38c2, 5); calld(Definitions.my_ctor_c17, -0x54b8); /* call 0x100ce40f */
            ii(0x100d_38c7, 6); mov(memd_a32[ss, ebp - 0xe8], eax);     /* mov [ebp-0xe8], eax */
            ii(0x100d_38cd, 6); mov(eax, memd_a32[ss, ebp - 0xe8]);     /* mov eax, [ebp-0xe8] */
            ii(0x100d_38d3, 6); mov(memd_a32[ss, ebp - 0x194], eax);    /* mov [ebp-0x194], eax */
            ii(0x100d_38d9, 2); jmpd(0x100d_38e7, 0xc); goto l_0x100d_38e7; /* jmp 0x100d38e7 */
        l_0x100d_38db:
            ii(0x100d_38db, 6); mov(eax, memd_a32[ss, ebp - 0xe4]);     /* mov eax, [ebp-0xe4] */
            ii(0x100d_38e1, 6); mov(memd_a32[ss, ebp - 0x194], eax);    /* mov [ebp-0x194], eax */
        l_0x100d_38e7:
            ii(0x100d_38e7, 6); mov(eax, memd_a32[ss, ebp - 0x194]);    /* mov eax, [ebp-0x194] */
            ii(0x100d_38ed, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_38f0, 3); mov(memd_a32[ds, edx + 0x62], eax);     /* mov [edx+0x62], eax */
            ii(0x100d_38f3, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_38f8, 5); calld(Definitions.sys_new, 0x9_2503);   /* call 0x10165e00 */
            ii(0x100d_38fd, 6); mov(memd_a32[ss, ebp - 0xd4], eax);     /* mov [ebp-0xd4], eax */
            ii(0x100d_3903, 6); mov(eax, memd_a32[ss, ebp - 0xd4]);     /* mov eax, [ebp-0xd4] */
            ii(0x100d_3909, 6); mov(memd_a32[ss, ebp - 0xd8], eax);     /* mov [ebp-0xd8], eax */
            ii(0x100d_390f, 7); cmp(memd_a32[ss, ebp - 0xd8], 0);       /* cmp dword [ebp-0xd8], 0x0 */
            ii(0x100d_3916, 2); if(jzd(0x100d_394c, 0x34)) goto l_0x100d_394c; /* jz 0x100d394c */
            ii(0x100d_3918, 5); mov(eax, 0x1a5);                        /* mov eax, 0x1a5 */
            ii(0x100d_391d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_391e, 5); mov(ecx, 0x124);                        /* mov ecx, 0x124 */
            ii(0x100d_3923, 5); mov(ebx, 0x133);                        /* mov ebx, 0x133 */
            ii(0x100d_3928, 5); mov(edx, 0x132);                        /* mov edx, 0x132 */
            ii(0x100d_392d, 6); mov(eax, memd_a32[ss, ebp - 0xd4]);     /* mov eax, [ebp-0xd4] */
            ii(0x100d_3933, 5); calld(Definitions.my_ctor_c17, -0x5529); /* call 0x100ce40f */
            ii(0x100d_3938, 6); mov(memd_a32[ss, ebp - 0xdc], eax);     /* mov [ebp-0xdc], eax */
            ii(0x100d_393e, 6); mov(eax, memd_a32[ss, ebp - 0xdc]);     /* mov eax, [ebp-0xdc] */
            ii(0x100d_3944, 6); mov(memd_a32[ss, ebp - 0x198], eax);    /* mov [ebp-0x198], eax */
            ii(0x100d_394a, 2); jmpd(0x100d_3958, 0xc); goto l_0x100d_3958; /* jmp 0x100d3958 */
        l_0x100d_394c:
            ii(0x100d_394c, 6); mov(eax, memd_a32[ss, ebp - 0xd8]);     /* mov eax, [ebp-0xd8] */
            ii(0x100d_3952, 6); mov(memd_a32[ss, ebp - 0x198], eax);    /* mov [ebp-0x198], eax */
        l_0x100d_3958:
            ii(0x100d_3958, 6); mov(eax, memd_a32[ss, ebp - 0x198]);    /* mov eax, [ebp-0x198] */
            ii(0x100d_395e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3961, 3); mov(memd_a32[ds, edx + 0x66], eax);     /* mov [edx+0x66], eax */
            ii(0x100d_3964, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_3969, 5); calld(Definitions.sys_new, 0x9_2492);   /* call 0x10165e00 */
            ii(0x100d_396e, 6); mov(memd_a32[ss, ebp - 0x15c], eax);    /* mov [ebp-0x15c], eax */
            ii(0x100d_3974, 6); mov(eax, memd_a32[ss, ebp - 0x15c]);    /* mov eax, [ebp-0x15c] */
            ii(0x100d_397a, 6); mov(memd_a32[ss, ebp - 0xcc], eax);     /* mov [ebp-0xcc], eax */
            ii(0x100d_3980, 7); cmp(memd_a32[ss, ebp - 0xcc], 0);       /* cmp dword [ebp-0xcc], 0x0 */
            ii(0x100d_3987, 2); if(jzd(0x100d_39bd, 0x34)) goto l_0x100d_39bd; /* jz 0x100d39bd */
            ii(0x100d_3989, 5); mov(eax, 0x125);                        /* mov eax, 0x125 */
            ii(0x100d_398e, 1); pushd(eax);                             /* push eax */
            ii(0x100d_398f, 5); mov(ecx, 0x19c);                        /* mov ecx, 0x19c */
            ii(0x100d_3994, 5); mov(ebx, 0x127);                        /* mov ebx, 0x127 */
            ii(0x100d_3999, 5); mov(edx, 0x126);                        /* mov edx, 0x126 */
            ii(0x100d_399e, 6); mov(eax, memd_a32[ss, ebp - 0x15c]);    /* mov eax, [ebp-0x15c] */
            ii(0x100d_39a4, 5); calld(Definitions.my_ctor_c17, -0x559a); /* call 0x100ce40f */
            ii(0x100d_39a9, 6); mov(memd_a32[ss, ebp - 0xd0], eax);     /* mov [ebp-0xd0], eax */
            ii(0x100d_39af, 6); mov(eax, memd_a32[ss, ebp - 0xd0]);     /* mov eax, [ebp-0xd0] */
            ii(0x100d_39b5, 6); mov(memd_a32[ss, ebp - 0x19c], eax);    /* mov [ebp-0x19c], eax */
            ii(0x100d_39bb, 2); jmpd(0x100d_39c9, 0xc); goto l_0x100d_39c9; /* jmp 0x100d39c9 */
        l_0x100d_39bd:
            ii(0x100d_39bd, 6); mov(eax, memd_a32[ss, ebp - 0xcc]);     /* mov eax, [ebp-0xcc] */
            ii(0x100d_39c3, 6); mov(memd_a32[ss, ebp - 0x19c], eax);    /* mov [ebp-0x19c], eax */
        l_0x100d_39c9:
            ii(0x100d_39c9, 6); mov(eax, memd_a32[ss, ebp - 0x19c]);    /* mov eax, [ebp-0x19c] */
            ii(0x100d_39cf, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_39d2, 6); mov(memd_a32[ds, edx + 0x9d], eax);     /* mov [edx+0x9d], eax */
            ii(0x100d_39d8, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_39dd, 5); calld(Definitions.sys_new, 0x9_241e);   /* call 0x10165e00 */
            ii(0x100d_39e2, 6); mov(memd_a32[ss, ebp - 0xbc], eax);     /* mov [ebp-0xbc], eax */
            ii(0x100d_39e8, 6); mov(eax, memd_a32[ss, ebp - 0xbc]);     /* mov eax, [ebp-0xbc] */
            ii(0x100d_39ee, 6); mov(memd_a32[ss, ebp - 0xc0], eax);     /* mov [ebp-0xc0], eax */
            ii(0x100d_39f4, 7); cmp(memd_a32[ss, ebp - 0xc0], 0);       /* cmp dword [ebp-0xc0], 0x0 */
            ii(0x100d_39fb, 2); if(jzd(0x100d_3a31, 0x34)) goto l_0x100d_3a31; /* jz 0x100d3a31 */
            ii(0x100d_39fd, 5); mov(eax, 0x142);                        /* mov eax, 0x142 */
            ii(0x100d_3a02, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3a03, 5); mov(ecx, 0x1bf);                        /* mov ecx, 0x1bf */
            ii(0x100d_3a08, 5); mov(ebx, 0x125);                        /* mov ebx, 0x125 */
            ii(0x100d_3a0d, 5); mov(edx, 0x124);                        /* mov edx, 0x124 */
            ii(0x100d_3a12, 6); mov(eax, memd_a32[ss, ebp - 0xbc]);     /* mov eax, [ebp-0xbc] */
            ii(0x100d_3a18, 5); calld(Definitions.my_ctor_c17, -0x560e); /* call 0x100ce40f */
            ii(0x100d_3a1d, 6); mov(memd_a32[ss, ebp - 0xc4], eax);     /* mov [ebp-0xc4], eax */
            ii(0x100d_3a23, 6); mov(eax, memd_a32[ss, ebp - 0xc4]);     /* mov eax, [ebp-0xc4] */
            ii(0x100d_3a29, 6); mov(memd_a32[ss, ebp - 0x1a0], eax);    /* mov [ebp-0x1a0], eax */
            ii(0x100d_3a2f, 2); jmpd(0x100d_3a3d, 0xc); goto l_0x100d_3a3d; /* jmp 0x100d3a3d */
        l_0x100d_3a31:
            ii(0x100d_3a31, 6); mov(eax, memd_a32[ss, ebp - 0xc0]);     /* mov eax, [ebp-0xc0] */
            ii(0x100d_3a37, 6); mov(memd_a32[ss, ebp - 0x1a0], eax);    /* mov [ebp-0x1a0], eax */
        l_0x100d_3a3d:
            ii(0x100d_3a3d, 6); mov(eax, memd_a32[ss, ebp - 0x1a0]);    /* mov eax, [ebp-0x1a0] */
            ii(0x100d_3a43, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3a46, 6); mov(memd_a32[ds, edx + 0xa5], eax);     /* mov [edx+0xa5], eax */
            ii(0x100d_3a4c, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_3a51, 5); calld(Definitions.sys_new, 0x9_23aa);   /* call 0x10165e00 */
            ii(0x100d_3a56, 6); mov(memd_a32[ss, ebp - 0xb0], eax);     /* mov [ebp-0xb0], eax */
            ii(0x100d_3a5c, 6); mov(eax, memd_a32[ss, ebp - 0xb0]);     /* mov eax, [ebp-0xb0] */
            ii(0x100d_3a62, 6); mov(memd_a32[ss, ebp - 0xb4], eax);     /* mov [ebp-0xb4], eax */
            ii(0x100d_3a68, 7); cmp(memd_a32[ss, ebp - 0xb4], 0);       /* cmp dword [ebp-0xb4], 0x0 */
            ii(0x100d_3a6f, 2); if(jzd(0x100d_3aa5, 0x34)) goto l_0x100d_3aa5; /* jz 0x100d3aa5 */
            ii(0x100d_3a71, 5); mov(eax, 0x1b9);                        /* mov eax, 0x1b9 */
            ii(0x100d_3a76, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3a77, 5); mov(ecx, 0x224);                        /* mov ecx, 0x224 */
            ii(0x100d_3a7c, 5); mov(ebx, 0x121);                        /* mov ebx, 0x121 */
            ii(0x100d_3a81, 5); mov(edx, 0x120);                        /* mov edx, 0x120 */
            ii(0x100d_3a86, 6); mov(eax, memd_a32[ss, ebp - 0xb0]);     /* mov eax, [ebp-0xb0] */
            ii(0x100d_3a8c, 5); calld(Definitions.my_ctor_c17, -0x5682); /* call 0x100ce40f */
            ii(0x100d_3a91, 6); mov(memd_a32[ss, ebp - 0xb8], eax);     /* mov [ebp-0xb8], eax */
            ii(0x100d_3a97, 6); mov(eax, memd_a32[ss, ebp - 0xb8]);     /* mov eax, [ebp-0xb8] */
            ii(0x100d_3a9d, 6); mov(memd_a32[ss, ebp - 0x1a4], eax);    /* mov [ebp-0x1a4], eax */
            ii(0x100d_3aa3, 2); jmpd(0x100d_3ab1, 0xc); goto l_0x100d_3ab1; /* jmp 0x100d3ab1 */
        l_0x100d_3aa5:
            ii(0x100d_3aa5, 6); mov(eax, memd_a32[ss, ebp - 0xb4]);     /* mov eax, [ebp-0xb4] */
            ii(0x100d_3aab, 6); mov(memd_a32[ss, ebp - 0x1a4], eax);    /* mov [ebp-0x1a4], eax */
        l_0x100d_3ab1:
            ii(0x100d_3ab1, 6); mov(eax, memd_a32[ss, ebp - 0x1a4]);    /* mov eax, [ebp-0x1a4] */
            ii(0x100d_3ab7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3aba, 6); mov(memd_a32[ds, edx + 0xa1], eax);     /* mov [edx+0xa1], eax */
            ii(0x100d_3ac0, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_3ac5, 5); calld(/* sys */ 0x1016_a24c, 0x9_6782); /* call 0x1016a24c */
            ii(0x100d_3aca, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100d_3acd, 5); calld(0x100d_5224, 0x1752);             /* call 0x100d5224 */
            ii(0x100d_3ad2, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3ad3, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_3ad6, 5); calld(0x100d_5250, 0x1775);             /* call 0x100d5250 */
            ii(0x100d_3adb, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3adc, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100d_3adf, 5); calld(0x100d_527c, 0x1798);             /* call 0x100d527c */
            ii(0x100d_3ae4, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3ae5, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100d_3ae8, 5); calld(0x100d_52a8, 0x17bb);             /* call 0x100d52a8 */
            ii(0x100d_3aed, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3aee, 5); calld(0x100d_52d4, 0x17e1);             /* call 0x100d52d4 */
            ii(0x100d_3af3, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_3af6, 5); calld(0x100d_52f8, 0x17fd);             /* call 0x100d52f8 */
            ii(0x100d_3afb, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_3afe, 5); mov(edx, StringDefinitions.Delete2);    /* mov edx, 0x101a15b3 */
            ii(0x100d_3b03, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3b06, 6); mov(eax, memd_a32[ds, eax + 0x9d]);     /* mov eax, [eax+0x9d] */
            ii(0x100d_3b0c, 5); calld(0x100c_ef64, -0x4bad);            /* call 0x100cef64 */
            ii(0x100d_3b11, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100d_3b14, 5); calld(0x100d_5224, 0x170b);             /* call 0x100d5224 */
            ii(0x100d_3b19, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3b1a, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100d_3b1d, 5); calld(0x100d_5250, 0x172e);             /* call 0x100d5250 */
            ii(0x100d_3b22, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3b23, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_3b26, 5); calld(0x100d_527c, 0x1751);             /* call 0x100d527c */
            ii(0x100d_3b2b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3b2c, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100d_3b2f, 5); calld(0x100d_52a8, 0x1774);             /* call 0x100d52a8 */
            ii(0x100d_3b34, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3b35, 5); calld(0x100d_52d4, 0x179a);             /* call 0x100d52d4 */
            ii(0x100d_3b3a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_3b3d, 5); calld(0x100d_52f8, 0x17b6);             /* call 0x100d52f8 */
            ii(0x100d_3b42, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_3b45, 5); mov(edx, StringDefinitions.Build);      /* mov edx, 0x101a15ba */
            ii(0x100d_3b4a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3b4d, 6); mov(eax, memd_a32[ds, eax + 0xa1]);     /* mov eax, [eax+0xa1] */
            ii(0x100d_3b53, 5); calld(0x100c_ef64, -0x4bf4);            /* call 0x100cef64 */
            ii(0x100d_3b58, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x100d_3b5d, 6); lea(edi, ebp - 0x1c0);                  /* lea edi, [ebp-0x1c0] */
            ii(0x100d_3b63, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x100d_3b66, 3); lea(esi, esi + 0x17);                   /* lea esi, [esi+0x17] */
            ii(0x100d_3b69, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x100d_3b6b, 2); movsw_a32();                            /* movsw */
            ii(0x100d_3b6d, 10); mov(memd_a32[ss, ebp - 0x1c0], 0x1e3); /* mov dword [ebp-0x1c0], 0x1e3 */
            ii(0x100d_3b77, 10); mov(memd_a32[ss, ebp - 0x1bc], 0x3c);  /* mov dword [ebp-0x1bc], 0x3c */
            ii(0x100d_3b81, 10); mov(memd_a32[ss, ebp - 0x1b8], 0x256); /* mov dword [ebp-0x1b8], 0x256 */
            ii(0x100d_3b8b, 10); mov(memd_a32[ss, ebp - 0x1b4], 0x1ad); /* mov dword [ebp-0x1b4], 0x1ad */
            ii(0x100d_3b95, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3b98, 3); mov(esi, memd_a32[ds, eax + 0x25]);     /* mov esi, [eax+0x25] */
            ii(0x100d_3b9b, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x100d_3b9e, 7); imul(esi, memd_a32[ss, ebp - 0x1bc]);   /* imul esi, [ebp-0x1bc] */
            ii(0x100d_3ba5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3ba8, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x100d_3bab, 6); add(eax, memd_a32[ss, ebp - 0x1c0]);    /* add eax, [ebp-0x1c0] */
            ii(0x100d_3bb1, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100d_3bb3, 6); mov(memd_a32[ss, ebp - 0x1aa], eax);    /* mov [ebp-0x1aa], eax */
            ii(0x100d_3bb9, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100d_3bbe, 5); calld(Definitions.sys_new, 0x9_223d);   /* call 0x10165e00 */
            ii(0x100d_3bc3, 6); mov(memd_a32[ss, ebp - 0x84], eax);     /* mov [ebp-0x84], eax */
            ii(0x100d_3bc9, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100d_3bcf, 6); mov(memd_a32[ss, ebp - 0x88], eax);     /* mov [ebp-0x88], eax */
            ii(0x100d_3bd5, 7); cmp(memd_a32[ss, ebp - 0x88], 0);       /* cmp dword [ebp-0x88], 0x0 */
            ii(0x100d_3bdc, 2); if(jzd(0x100d_3c24, 0x46)) goto l_0x100d_3c24; /* jz 0x100d3c24 */
            ii(0x100d_3bde, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3be1, 3); pushd(memd_a32[ds, eax + 0x46]);        /* push dword [eax+0x46] */
            ii(0x100d_3be4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3be7, 3); pushd(memd_a32[ds, eax + 0x42]);        /* push dword [eax+0x42] */
            ii(0x100d_3bea, 5); mov(eax, 0x7d0);                        /* mov eax, 0x7d0 */
            ii(0x100d_3bef, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3bf0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3bf3, 3); pushd(memd_a32[ds, eax + 0x31]);        /* push dword [eax+0x31] */
            ii(0x100d_3bf6, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100d_3bf9, 3); add(ecx, 0x3a);                         /* add ecx, 0x3a */
            ii(0x100d_3bfc, 6); lea(ebx, ebp - 0x1c0);                  /* lea ebx, [ebp-0x1c0] */
            ii(0x100d_3c02, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3c05, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100d_3c0b, 5); calld(0x100d_0b0a, -0x3106);            /* call 0x100d0b0a */
            ii(0x100d_3c10, 6); mov(memd_a32[ss, ebp - 0x8c], eax);     /* mov [ebp-0x8c], eax */
            ii(0x100d_3c16, 6); mov(eax, memd_a32[ss, ebp - 0x8c]);     /* mov eax, [ebp-0x8c] */
            ii(0x100d_3c1c, 6); mov(memd_a32[ss, ebp - 0x1c4], eax);    /* mov [ebp-0x1c4], eax */
            ii(0x100d_3c22, 2); jmpd(0x100d_3c30, 0xc); goto l_0x100d_3c30; /* jmp 0x100d3c30 */
        l_0x100d_3c24:
            ii(0x100d_3c24, 6); mov(eax, memd_a32[ss, ebp - 0x88]);     /* mov eax, [ebp-0x88] */
            ii(0x100d_3c2a, 6); mov(memd_a32[ss, ebp - 0x1c4], eax);    /* mov [ebp-0x1c4], eax */
        l_0x100d_3c30:
            ii(0x100d_3c30, 6); mov(eax, memd_a32[ss, ebp - 0x1c4]);    /* mov eax, [ebp-0x1c4] */
            ii(0x100d_3c36, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3c39, 3); mov(memd_a32[ds, edx + 0x3e], eax);     /* mov [edx+0x3e], eax */
            ii(0x100d_3c3c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3c3f, 3); mov(edx, memd_a32[ds, eax + 0x3e]);     /* mov edx, [eax+0x3e] */
            ii(0x100d_3c42, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3c45, 6); mov(memd_a32[ds, eax + 0x91], edx);     /* mov [eax+0x91], edx */
            ii(0x100d_3c4b, 10); mov(memd_a32[ss, ebp - 0x1c0], 0x151); /* mov dword [ebp-0x1c0], 0x151 */
            ii(0x100d_3c55, 10); mov(memd_a32[ss, ebp - 0x1bc], 0x3c);  /* mov dword [ebp-0x1bc], 0x3c */
            ii(0x100d_3c5f, 10); mov(memd_a32[ss, ebp - 0x1b8], 0x1c5); /* mov dword [ebp-0x1b8], 0x1c5 */
            ii(0x100d_3c69, 10); mov(memd_a32[ss, ebp - 0x1b4], 0x118); /* mov dword [ebp-0x1b4], 0x118 */
            ii(0x100d_3c73, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3c76, 3); mov(edx, memd_a32[ds, eax + 0x25]);     /* mov edx, [eax+0x25] */
            ii(0x100d_3c79, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_3c7c, 7); imul(edx, memd_a32[ss, ebp - 0x1bc]);   /* imul edx, [ebp-0x1bc] */
            ii(0x100d_3c83, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3c86, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x100d_3c89, 6); add(eax, memd_a32[ss, ebp - 0x1c0]);    /* add eax, [ebp-0x1c0] */
            ii(0x100d_3c8f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_3c91, 6); mov(memd_a32[ss, ebp - 0x1aa], eax);    /* mov [ebp-0x1aa], eax */
            ii(0x100d_3c97, 5); mov(eax, 0x44);                         /* mov eax, 0x44 */
            ii(0x100d_3c9c, 5); calld(Definitions.sys_new, 0x9_215f);   /* call 0x10165e00 */
            ii(0x100d_3ca1, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x100d_3ca4, 3); mov(eax, memd_a32[ss, ebp - 0x78]);     /* mov eax, [ebp-0x78] */
            ii(0x100d_3ca7, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x100d_3caa, 4); cmp(memd_a32[ss, ebp - 0x7c], 0);       /* cmp dword [ebp-0x7c], 0x0 */
            ii(0x100d_3cae, 2); if(jzd(0x100d_3cfa, 0x4a)) goto l_0x100d_3cfa; /* jz 0x100d3cfa */
            ii(0x100d_3cb0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3cb3, 6); pushd(memd_a32[ds, eax + 0x99]);        /* push dword [eax+0x99] */
            ii(0x100d_3cb9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_3cbc, 6); pushd(memd_a32[ds, eax + 0x95]);        /* push dword [eax+0x95] */
            ii(0x100d_3cc2, 5); mov(eax, 0xbb8);                        /* mov eax, 0xbb8 */
            ii(0x100d_3cc7, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3cc8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_3ccb, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100d_3cce, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100d_3cd0, 1); cwde();                                 /* cwde */
            ii(0x100d_3cd1, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3cd2, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100d_3cd5, 6); add(ecx, 0x87);                         /* add ecx, 0x87 */
            ii(0x100d_3cdb, 6); lea(ebx, ebp - 0x1c0);                  /* lea ebx, [ebp-0x1c0] */
            ii(0x100d_3ce1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3ce4, 3); mov(eax, memd_a32[ss, ebp - 0x78]);     /* mov eax, [ebp-0x78] */
            ii(0x100d_3ce7, 5); calld(0x100c_fe4d, -0x3e9f);            /* call 0x100cfe4d */
            ii(0x100d_3cec, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x100d_3cef, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x100d_3cf2, 6); mov(memd_a32[ss, ebp - 0x1c8], eax);    /* mov [ebp-0x1c8], eax */
            ii(0x100d_3cf8, 2); jmpd(0x100d_3d03, 0x9); goto l_0x100d_3d03; /* jmp 0x100d3d03 */
        l_0x100d_3cfa:
            ii(0x100d_3cfa, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100d_3cfd, 6); mov(memd_a32[ss, ebp - 0x1c8], eax);    /* mov [ebp-0x1c8], eax */
        l_0x100d_3d03:
            ii(0x100d_3d03, 6); mov(eax, memd_a32[ss, ebp - 0x1c8]);    /* mov eax, [ebp-0x1c8] */
            ii(0x100d_3d09, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3d0c, 6); mov(memd_a32[ds, edx + 0x8d], eax);     /* mov [edx+0x8d], eax */
            ii(0x100d_3d12, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_3d17, 5); calld(Definitions.sys_new, 0x9_20e4);   /* call 0x10165e00 */
            ii(0x100d_3d1c, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100d_3d1f, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x100d_3d22, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100d_3d25, 4); cmp(memd_a32[ss, ebp - 0x70], 0);       /* cmp dword [ebp-0x70], 0x0 */
            ii(0x100d_3d29, 2); if(jzd(0x100d_3d56, 0x2b)) goto l_0x100d_3d56; /* jz 0x100d3d56 */
            ii(0x100d_3d2b, 5); mov(eax, 0xae);                         /* mov eax, 0xae */
            ii(0x100d_3d30, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3d31, 5); mov(ecx, 0xfa);                         /* mov ecx, 0xfa */
            ii(0x100d_3d36, 5); mov(ebx, 0x125);                        /* mov ebx, 0x125 */
            ii(0x100d_3d3b, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x100d_3d40, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x100d_3d43, 5); calld(0x100d_7bdc, 0x3e94);             /* call 0x100d7bdc */
            ii(0x100d_3d48, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x100d_3d4b, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x100d_3d4e, 6); mov(memd_a32[ss, ebp - 0x1cc], eax);    /* mov [ebp-0x1cc], eax */
            ii(0x100d_3d54, 2); jmpd(0x100d_3d5f, 0x9); goto l_0x100d_3d5f; /* jmp 0x100d3d5f */
        l_0x100d_3d56:
            ii(0x100d_3d56, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x100d_3d59, 6); mov(memd_a32[ss, ebp - 0x1cc], eax);    /* mov [ebp-0x1cc], eax */
        l_0x100d_3d5f:
            ii(0x100d_3d5f, 6); mov(eax, memd_a32[ss, ebp - 0x1cc]);    /* mov eax, [ebp-0x1cc] */
            ii(0x100d_3d65, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3d68, 3); mov(memd_a32[ds, edx + 0x6a], eax);     /* mov [edx+0x6a], eax */
            ii(0x100d_3d6b, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_3d70, 5); calld(Definitions.sys_new, 0x9_208b);   /* call 0x10165e00 */
            ii(0x100d_3d75, 6); mov(memd_a32[ss, ebp - 0x9c], eax);     /* mov [ebp-0x9c], eax */
            ii(0x100d_3d7b, 6); mov(eax, memd_a32[ss, ebp - 0x9c]);     /* mov eax, [ebp-0x9c] */
            ii(0x100d_3d81, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x100d_3d84, 4); cmp(memd_a32[ss, ebp - 0x64], 0);       /* cmp dword [ebp-0x64], 0x0 */
            ii(0x100d_3d88, 2); if(jzd(0x100d_3db8, 0x2e)) goto l_0x100d_3db8; /* jz 0x100d3db8 */
            ii(0x100d_3d8a, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_3d8f, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3d90, 5); mov(ecx, 0x14);                         /* mov ecx, 0x14 */
            ii(0x100d_3d95, 5); mov(ebx, 0x178);                        /* mov ebx, 0x178 */
            ii(0x100d_3d9a, 5); mov(edx, 0x17a);                        /* mov edx, 0x17a */
            ii(0x100d_3d9f, 6); mov(eax, memd_a32[ss, ebp - 0x9c]);     /* mov eax, [ebp-0x9c] */
            ii(0x100d_3da5, 5); calld(0x100d_7bdc, 0x3e32);             /* call 0x100d7bdc */
            ii(0x100d_3daa, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100d_3dad, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100d_3db0, 6); mov(memd_a32[ss, ebp - 0x1d0], eax);    /* mov [ebp-0x1d0], eax */
            ii(0x100d_3db6, 2); jmpd(0x100d_3dc1, 0x9); goto l_0x100d_3dc1; /* jmp 0x100d3dc1 */
        l_0x100d_3db8:
            ii(0x100d_3db8, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x100d_3dbb, 6); mov(memd_a32[ss, ebp - 0x1d0], eax);    /* mov [ebp-0x1d0], eax */
        l_0x100d_3dc1:
            ii(0x100d_3dc1, 6); mov(eax, memd_a32[ss, ebp - 0x1d0]);    /* mov eax, [ebp-0x1d0] */
            ii(0x100d_3dc7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3dca, 3); mov(memd_a32[ds, edx + 0x6e], eax);     /* mov [edx+0x6e], eax */
            ii(0x100d_3dcd, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_3dd2, 5); calld(Definitions.sys_new, 0x9_2029);   /* call 0x10165e00 */
            ii(0x100d_3dd7, 6); mov(memd_a32[ss, ebp - 0x90], eax);     /* mov [ebp-0x90], eax */
            ii(0x100d_3ddd, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100d_3de3, 6); mov(memd_a32[ss, ebp - 0x94], eax);     /* mov [ebp-0x94], eax */
            ii(0x100d_3de9, 7); cmp(memd_a32[ss, ebp - 0x94], 0);       /* cmp dword [ebp-0x94], 0x0 */
            ii(0x100d_3df0, 2); if(jzd(0x100d_3e26, 0x34)) goto l_0x100d_3e26; /* jz 0x100d3e26 */
            ii(0x100d_3df2, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_3df7, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3df8, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x100d_3dfd, 5); mov(ebx, 0x178);                        /* mov ebx, 0x178 */
            ii(0x100d_3e02, 5); mov(edx, 0x19e);                        /* mov edx, 0x19e */
            ii(0x100d_3e07, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100d_3e0d, 5); calld(0x100d_7bdc, 0x3dca);             /* call 0x100d7bdc */
            ii(0x100d_3e12, 6); mov(memd_a32[ss, ebp - 0x98], eax);     /* mov [ebp-0x98], eax */
            ii(0x100d_3e18, 6); mov(eax, memd_a32[ss, ebp - 0x98]);     /* mov eax, [ebp-0x98] */
            ii(0x100d_3e1e, 6); mov(memd_a32[ss, ebp - 0x1d4], eax);    /* mov [ebp-0x1d4], eax */
            ii(0x100d_3e24, 2); jmpd(0x100d_3e32, 0xc); goto l_0x100d_3e32; /* jmp 0x100d3e32 */
        l_0x100d_3e26:
            ii(0x100d_3e26, 6); mov(eax, memd_a32[ss, ebp - 0x94]);     /* mov eax, [ebp-0x94] */
            ii(0x100d_3e2c, 6); mov(memd_a32[ss, ebp - 0x1d4], eax);    /* mov [ebp-0x1d4], eax */
        l_0x100d_3e32:
            ii(0x100d_3e32, 6); mov(eax, memd_a32[ss, ebp - 0x1d4]);    /* mov eax, [ebp-0x1d4] */
            ii(0x100d_3e38, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3e3b, 3); mov(memd_a32[ds, edx + 0x72], eax);     /* mov [edx+0x72], eax */
            ii(0x100d_3e3e, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_3e43, 5); calld(Definitions.sys_new, 0x9_1fb8);   /* call 0x10165e00 */
            ii(0x100d_3e48, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100d_3e4b, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100d_3e4e, 6); mov(memd_a32[ss, ebp - 0xc8], eax);     /* mov [ebp-0xc8], eax */
            ii(0x100d_3e54, 7); cmp(memd_a32[ss, ebp - 0xc8], 0);       /* cmp dword [ebp-0xc8], 0x0 */
            ii(0x100d_3e5b, 2); if(jzd(0x100d_3e88, 0x2b)) goto l_0x100d_3e88; /* jz 0x100d3e88 */
            ii(0x100d_3e5d, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_3e62, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3e63, 5); mov(ecx, 0x14);                         /* mov ecx, 0x14 */
            ii(0x100d_3e68, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x100d_3e6d, 5); mov(edx, 0x17a);                        /* mov edx, 0x17a */
            ii(0x100d_3e72, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100d_3e75, 5); calld(0x100d_7bdc, 0x3d62);             /* call 0x100d7bdc */
            ii(0x100d_3e7a, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x100d_3e7d, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x100d_3e80, 6); mov(memd_a32[ss, ebp - 0x1d8], eax);    /* mov [ebp-0x1d8], eax */
            ii(0x100d_3e86, 2); jmpd(0x100d_3e94, 0xc); goto l_0x100d_3e94; /* jmp 0x100d3e94 */
        l_0x100d_3e88:
            ii(0x100d_3e88, 6); mov(eax, memd_a32[ss, ebp - 0xc8]);     /* mov eax, [ebp-0xc8] */
            ii(0x100d_3e8e, 6); mov(memd_a32[ss, ebp - 0x1d8], eax);    /* mov [ebp-0x1d8], eax */
        l_0x100d_3e94:
            ii(0x100d_3e94, 6); mov(eax, memd_a32[ss, ebp - 0x1d8]);    /* mov eax, [ebp-0x1d8] */
            ii(0x100d_3e9a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3e9d, 3); mov(memd_a32[ds, edx + 0x76], eax);     /* mov [edx+0x76], eax */
            ii(0x100d_3ea0, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_3ea5, 5); calld(Definitions.sys_new, 0x9_1f56);   /* call 0x10165e00 */
            ii(0x100d_3eaa, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100d_3ead, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100d_3eb0, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100d_3eb3, 4); cmp(memd_a32[ss, ebp - 0x4c], 0);       /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x100d_3eb7, 2); if(jzd(0x100d_3ee4, 0x2b)) goto l_0x100d_3ee4; /* jz 0x100d3ee4 */
            ii(0x100d_3eb9, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_3ebe, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3ebf, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x100d_3ec4, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x100d_3ec9, 5); mov(edx, 0x19e);                        /* mov edx, 0x19e */
            ii(0x100d_3ece, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100d_3ed1, 5); calld(0x100d_7bdc, 0x3d06);             /* call 0x100d7bdc */
            ii(0x100d_3ed6, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100d_3ed9, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100d_3edc, 6); mov(memd_a32[ss, ebp - 0x1dc], eax);    /* mov [ebp-0x1dc], eax */
            ii(0x100d_3ee2, 2); jmpd(0x100d_3eed, 0x9); goto l_0x100d_3eed; /* jmp 0x100d3eed */
        l_0x100d_3ee4:
            ii(0x100d_3ee4, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100d_3ee7, 6); mov(memd_a32[ss, ebp - 0x1dc], eax);    /* mov [ebp-0x1dc], eax */
        l_0x100d_3eed:
            ii(0x100d_3eed, 6); mov(eax, memd_a32[ss, ebp - 0x1dc]);    /* mov eax, [ebp-0x1dc] */
            ii(0x100d_3ef3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3ef6, 3); mov(memd_a32[ds, edx + 0x7a], eax);     /* mov [edx+0x7a], eax */
            ii(0x100d_3ef9, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_3efe, 5); calld(Definitions.sys_new, 0x9_1efd);   /* call 0x10165e00 */
            ii(0x100d_3f03, 6); mov(memd_a32[ss, ebp - 0xac], eax);     /* mov [ebp-0xac], eax */
            ii(0x100d_3f09, 6); mov(eax, memd_a32[ss, ebp - 0xac]);     /* mov eax, [ebp-0xac] */
            ii(0x100d_3f0f, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x100d_3f12, 4); cmp(memd_a32[ss, ebp - 0x60], 0);       /* cmp dword [ebp-0x60], 0x0 */
            ii(0x100d_3f16, 2); if(jzd(0x100d_3f46, 0x2e)) goto l_0x100d_3f46; /* jz 0x100d3f46 */
            ii(0x100d_3f18, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_3f1d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3f1e, 5); mov(ecx, 0x14);                         /* mov ecx, 0x14 */
            ii(0x100d_3f23, 5); mov(ebx, 0x1aa);                        /* mov ebx, 0x1aa */
            ii(0x100d_3f28, 5); mov(edx, 0x17a);                        /* mov edx, 0x17a */
            ii(0x100d_3f2d, 6); mov(eax, memd_a32[ss, ebp - 0xac]);     /* mov eax, [ebp-0xac] */
            ii(0x100d_3f33, 5); calld(0x100d_7bdc, 0x3ca4);             /* call 0x100d7bdc */
            ii(0x100d_3f38, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100d_3f3b, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100d_3f3e, 6); mov(memd_a32[ss, ebp - 0x1e0], eax);    /* mov [ebp-0x1e0], eax */
            ii(0x100d_3f44, 2); jmpd(0x100d_3f4f, 0x9); goto l_0x100d_3f4f; /* jmp 0x100d3f4f */
        l_0x100d_3f46:
            ii(0x100d_3f46, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100d_3f49, 6); mov(memd_a32[ss, ebp - 0x1e0], eax);    /* mov [ebp-0x1e0], eax */
        l_0x100d_3f4f:
            ii(0x100d_3f4f, 6); mov(eax, memd_a32[ss, ebp - 0x1e0]);    /* mov eax, [ebp-0x1e0] */
            ii(0x100d_3f55, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3f58, 3); mov(memd_a32[ds, edx + 0x7e], eax);     /* mov [edx+0x7e], eax */
            ii(0x100d_3f5b, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_3f60, 5); calld(Definitions.sys_new, 0x9_1e9b);   /* call 0x10165e00 */
            ii(0x100d_3f65, 6); mov(memd_a32[ss, ebp - 0xa0], eax);     /* mov [ebp-0xa0], eax */
            ii(0x100d_3f6b, 6); mov(eax, memd_a32[ss, ebp - 0xa0]);     /* mov eax, [ebp-0xa0] */
            ii(0x100d_3f71, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x100d_3f77, 7); cmp(memd_a32[ss, ebp - 0xa4], 0);       /* cmp dword [ebp-0xa4], 0x0 */
            ii(0x100d_3f7e, 2); if(jzd(0x100d_3fb4, 0x34)) goto l_0x100d_3fb4; /* jz 0x100d3fb4 */
            ii(0x100d_3f80, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_3f85, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3f86, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x100d_3f8b, 5); mov(ebx, 0x1aa);                        /* mov ebx, 0x1aa */
            ii(0x100d_3f90, 5); mov(edx, 0x19e);                        /* mov edx, 0x19e */
            ii(0x100d_3f95, 6); mov(eax, memd_a32[ss, ebp - 0xa0]);     /* mov eax, [ebp-0xa0] */
            ii(0x100d_3f9b, 5); calld(0x100d_7bdc, 0x3c3c);             /* call 0x100d7bdc */
            ii(0x100d_3fa0, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x100d_3fa6, 6); mov(eax, memd_a32[ss, ebp - 0xa8]);     /* mov eax, [ebp-0xa8] */
            ii(0x100d_3fac, 6); mov(memd_a32[ss, ebp - 0x1e4], eax);    /* mov [ebp-0x1e4], eax */
            ii(0x100d_3fb2, 2); jmpd(0x100d_3fc0, 0xc); goto l_0x100d_3fc0; /* jmp 0x100d3fc0 */
        l_0x100d_3fb4:
            ii(0x100d_3fb4, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100d_3fba, 6); mov(memd_a32[ss, ebp - 0x1e4], eax);    /* mov [ebp-0x1e4], eax */
        l_0x100d_3fc0:
            ii(0x100d_3fc0, 6); mov(eax, memd_a32[ss, ebp - 0x1e4]);    /* mov eax, [ebp-0x1e4] */
            ii(0x100d_3fc6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_3fc9, 6); mov(memd_a32[ds, edx + 0x82], eax);     /* mov [edx+0x82], eax */
            ii(0x100d_3fcf, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_3fd4, 5); calld(/* sys */ 0x1016_a24c, 0x9_6273); /* call 0x1016a24c */
            ii(0x100d_3fd9, 5); calld(0x100d_531c, 0x133e);             /* call 0x100d531c */
            ii(0x100d_3fde, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_3fe3, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3fe4, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_3fe9, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3fea, 2); pushd(0x2);                             /* push 0x2 */
            ii(0x100d_3fec, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x100d_3ff1, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3ff2, 5); mov(eax, 0x9e);                         /* mov eax, 0x9e */
            ii(0x100d_3ff7, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3ff8, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x100d_3ffd, 1); pushd(eax);                             /* push eax */
            ii(0x100d_3ffe, 5); mov(ecx, 0x147);                        /* mov ecx, 0x147 */
            ii(0x100d_4003, 5); mov(ebx, StringDefinitions.FactoryMenu); /* mov ebx, 0x101a15c0 */
            ii(0x100d_4008, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_400b, 3); mov(edx, memd_a32[ds, eax + 0x25]);     /* mov edx, [eax+0x25] */
            ii(0x100d_400e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_4011, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4014, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x100d_4017, 5); calld(0x100e_9ae5, 0x1_5ac9);           /* call 0x100e9ae5 */
            ii(0x100d_401c, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_4021, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_4024, 5); calld(0x100d_4d78, 0xd4f);              /* call 0x100d4d78 */
            ii(0x100d_4029, 1); pushd(eax);                             /* push eax */
            ii(0x100d_402a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_402f, 1); pushd(eax);                             /* push eax */
            ii(0x100d_4030, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_4035, 1); pushd(eax);                             /* push eax */
            ii(0x100d_4036, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100d_403b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_403c, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x100d_4041, 1); pushd(eax);                             /* push eax */
            ii(0x100d_4042, 5); mov(ecx, 0x108);                        /* mov ecx, 0x108 */
            ii(0x100d_4047, 5); mov(ebx, 0xd1);                         /* mov ebx, 0xd1 */
            ii(0x100d_404c, 5); mov(edx, StringDefinitions.Description4); /* mov edx, 0x101a15cd */
            ii(0x100d_4051, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4054, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_4057, 5); calld(0x100e_ab9d, 0x1_6b41);           /* call 0x100eab9d */
            ii(0x100d_405c, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_4061, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_4064, 5); calld(0x100d_4d78, 0xd0f);              /* call 0x100d4d78 */
            ii(0x100d_4069, 1); pushd(eax);                             /* push eax */
            ii(0x100d_406a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_406f, 1); pushd(eax);                             /* push eax */
            ii(0x100d_4070, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_4075, 1); pushd(eax);                             /* push eax */
            ii(0x100d_4076, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_407b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_407c, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x100d_4081, 1); pushd(eax);                             /* push eax */
            ii(0x100d_4082, 5); mov(ecx, 0x165);                        /* mov ecx, 0x165 */
            ii(0x100d_4087, 5); mov(ebx, 0x170);                        /* mov ebx, 0x170 */
            ii(0x100d_408c, 5); mov(edx, StringDefinitions.Turns3);     /* mov edx, 0x101a15d9 */
            ii(0x100d_4091, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4094, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_4097, 5); calld(0x100e_ab9d, 0x1_6b01);           /* call 0x100eab9d */
            ii(0x100d_409c, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_40a1, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_40a4, 5); calld(0x100d_4d78, 0xccf);              /* call 0x100d4d78 */
            ii(0x100d_40a9, 1); pushd(eax);                             /* push eax */
            ii(0x100d_40aa, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_40af, 1); pushd(eax);                             /* push eax */
            ii(0x100d_40b0, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_40b5, 1); pushd(eax);                             /* push eax */
            ii(0x100d_40b6, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_40bb, 1); pushd(eax);                             /* push eax */
            ii(0x100d_40bc, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x100d_40c1, 1); pushd(eax);                             /* push eax */
            ii(0x100d_40c2, 5); mov(ecx, 0x165);                        /* mov ecx, 0x165 */
            ii(0x100d_40c7, 5); mov(ebx, 0x199);                        /* mov ebx, 0x199 */
            ii(0x100d_40cc, 5); mov(edx, StringDefinitions.Cost7);      /* mov edx, 0x101a15df */
            ii(0x100d_40d1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_40d4, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_40d7, 5); calld(0x100e_ab9d, 0x1_6ac1);           /* call 0x100eab9d */
            ii(0x100d_40dc, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_40e1, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100d_40e4, 5); calld(0x100d_4d78, 0xc8f);              /* call 0x100d4d78 */
            ii(0x100d_40e9, 1); pushd(eax);                             /* push eax */
            ii(0x100d_40ea, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_40ef, 1); pushd(eax);                             /* push eax */
            ii(0x100d_40f0, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_40f5, 1); pushd(eax);                             /* push eax */
            ii(0x100d_40f6, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100d_40fb, 1); pushd(eax);                             /* push eax */
            ii(0x100d_40fc, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x100d_4101, 1); pushd(eax);                             /* push eax */
            ii(0x100d_4102, 5); mov(ecx, 0x142);                        /* mov ecx, 0x142 */
            ii(0x100d_4107, 5); mov(ebx, 0x18b);                        /* mov ebx, 0x18b */
            ii(0x100d_410c, 5); mov(edx, StringDefinitions.Repeat);     /* mov edx, 0x101a15e4 */
            ii(0x100d_4111, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4114, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_4117, 5); calld(0x100e_ab9d, 0x1_6a81);           /* call 0x100eab9d */
            ii(0x100d_411c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_411f, 6); mov(memd_a32[ss, ebp - 0x16c], eax);    /* mov [ebp-0x16c], eax */
            ii(0x100d_4125, 6); mov(eax, memd_a32[ss, ebp - 0x16c]);    /* mov eax, [ebp-0x16c] */
            ii(0x100d_412b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_412d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_412e, 1); popd(edi);                              /* pop edi */
            ii(0x100d_412f, 1); popd(esi);                              /* pop esi */
            ii(0x100d_4130, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_4131, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_4132, 1); retd(); return;                         /* ret */
        }
    }
}
