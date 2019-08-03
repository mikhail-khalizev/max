using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0008c5c9-e0bb-4155-92e3-b5e60f304c1c")]
        public void Method_1011_9138()
        {
            ii(0x1011_9138, 5); pushd(0x78);                            /* push 0x78 */
            ii(0x1011_913d, 5); calld(Definitions.sys_check_available_stack_size, 0x4cc10); /* call 0x10165d52 */
            ii(0x1011_9142, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_9143, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_9144, 1); pushd(edx);                             /* push edx */
            ii(0x1011_9145, 1); pushd(esi);                             /* push esi */
            ii(0x1011_9146, 1); pushd(edi);                             /* push edi */
            ii(0x1011_9147, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_9148, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_914a, 6); sub(esp, 0x50);                         /* sub esp, 0x50 */
            ii(0x1011_9150, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_9153, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9156, 5); calld(0x1015_48ba, 0x3b75f);            /* call 0x101548ba */
            ii(0x1011_915b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_915e, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1011_9162, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_9165, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9168, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1011_916c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_916f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9172, 4); mov(ax, memw_a32[ds, eax + 0x41]);      /* mov ax, [eax+0x41] */
            ii(0x1011_9176, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_9179, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_917c, 4); mov(ax, memw_a32[ds, eax + 0x43]);      /* mov ax, [eax+0x43] */
            ii(0x1011_9180, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_9183, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_9185, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9188, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_918b, 5); calld(0x1013_ad71, 0x21be1);            /* call 0x1013ad71 */
            ii(0x1011_9190, 2); test(al, al);                           /* test al, al */
            ii(0x1011_9192, 2); if(jzd(0x1011_91c7, 0x33)) goto l_0x1011_91c7; /* jz 0x101191c7 */
            ii(0x1011_9194, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9197, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_919a, 5); calld(0x1007_69d8, -0xa27c7);           /* call 0x100769d8 */
            ii(0x1011_919f, 5); calld(0x1012_0c30, 0x7a8c);             /* call 0x10120c30 */
            ii(0x1011_91a4, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_91a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_91aa, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_91ad, 5); calld(0x1007_69d8, -0xa27da);           /* call 0x100769d8 */
            ii(0x1011_91b2, 5); calld(0x1012_0bfc, 0x7a45);             /* call 0x10120bfc */
            ii(0x1011_91b7, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_91ba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_91bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_91bf, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_91c2, 5); calld(0x1007_6a34, -0xa2793);           /* call 0x10076a34 */
        l_0x1011_91c7:
            ii(0x1011_91c7, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_91ca, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1011_91cd, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_91d0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_91d3, 3); sub(eax, memd_a32[ss, ebp - 0x1c]);     /* sub eax, [ebp-0x1c] */
            ii(0x1011_91d6, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1011_91d9, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1011_91dd, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_91e1, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1011_91e4, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1011_91e6, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1011_91ea, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1011_91ee, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1011_91f1, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1011_91f3, 3); mov(memd_a32[ss, ebp - 0x3c], ebx);     /* mov [ebp-0x3c], ebx */
            ii(0x1011_91f6, 3); fild(memd_a32[ss, ebp - 0x3c]);         /* fild dword [ebp-0x3c] */
            ii(0x1011_91f9, 5); calld(Definitions.sys_sqrt, 0x4ce48);   /* call 0x10166046 */
            ii(0x1011_91fe, 6); fmul(memq_a32[ds, 0x101a_7c8a]);        /* fmul qword [0x101a7c8a] */
            ii(0x1011_9204, 6); fadd(memq_a32[ds, 0x101a_7c92]);        /* fadd qword [0x101a7c92] */
            ii(0x1011_920a, 5); calld(Definitions.sys_round, 0x4ce6f);  /* call 0x1016607e */
            ii(0x1011_920f, 3); fistp(memd_a32[ss, ebp - 0x3c]);        /* fistp dword [ebp-0x3c] */
            ii(0x1011_9212, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1011_9215, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_9218, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_921c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_921e, 2); if(jnzd(0x1011_922c, 0xc)) goto l_0x1011_922c; /* jnz 0x1011922c */
            ii(0x1011_9220, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
            ii(0x1011_9227, 5); jmpd(0x1011_94aa, 0x27e); goto l_0x1011_94aa; /* jmp 0x101194aa */
        l_0x1011_922c:
            ii(0x1011_922c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_922f, 3); mov(al, memb_a32[ds, eax + 0x64]);      /* mov al, [eax+0x64] */
            ii(0x1011_9232, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_9234, 3); sub(memd_a32[ss, ebp - 0x8], eax);      /* sub [ebp-0x8], eax */
            ii(0x1011_9237, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_923b, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1011_923e, 2); if(jged(0x1011_9247, 0x7)) goto l_0x1011_9247; /* jge 0x10119247 */
            ii(0x1011_9240, 7); mov(memd_a32[ss, ebp - 0x8], 0x2);      /* mov dword [ebp-0x8], 0x2 */
        l_0x1011_9247:
            ii(0x1011_9247, 7); cmp(memb_a32[ds, 0x101c_3915], 0);      /* cmp byte [0x101c3915], 0x0 */
            ii(0x1011_924e, 2); if(jzd(0x1011_9258, 0x8)) goto l_0x1011_9258; /* jz 0x10119258 */
            ii(0x1011_9250, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9253, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_9256, 2); jmpd(0x1011_928f, 0x37); goto l_0x1011_928f; /* jmp 0x1011928f */
        l_0x1011_9258:
            ii(0x1011_9258, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_925b, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1011_925e, 3); mov(memb_a32[ss, ebp - 0x40], al);      /* mov [ebp-0x40], al */
            ii(0x1011_9261, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9264, 4); cmp(memb_a32[ds, eax + 0x4f], 0);       /* cmp byte [eax+0x4f], 0x0 */
            ii(0x1011_9268, 2); if(jzd(0x1011_9275, 0xb)) goto l_0x1011_9275; /* jz 0x10119275 */
            ii(0x1011_926a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_926d, 3); mov(al, memb_a32[ds, eax + 0x4f]);      /* mov al, [eax+0x4f] */
            ii(0x1011_9270, 2); dec(al);                                /* dec al */
            ii(0x1011_9272, 3); mov(memb_a32[ss, ebp - 0x40], al);      /* mov [ebp-0x40], al */
        l_0x1011_9275:
            ii(0x1011_9275, 4); cmp(memb_a32[ss, ebp - 0x40], 0);       /* cmp byte [ebp-0x40], 0x0 */
            ii(0x1011_9279, 2); if(jzd(0x1011_9288, 0xd)) goto l_0x1011_9288; /* jz 0x10119288 */
            ii(0x1011_927b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_927d, 3); mov(al, memb_a32[ss, ebp - 0x40]);      /* mov al, [ebp-0x40] */
            ii(0x1011_9280, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_9283, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_9286, 2); jmpd(0x1011_928f, 0x7); goto l_0x1011_928f; /* jmp 0x1011928f */
        l_0x1011_9288:
            ii(0x1011_9288, 7); mov(memd_a32[ss, ebp - 0x28], 0x7fff);  /* mov dword [ebp-0x28], 0x7fff */
        l_0x1011_928f:
            ii(0x1011_928f, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1011_9292, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1011_9296, 2); if(jld(0x1011_92d5, 0x3d)) goto l_0x1011_92d5; /* jl 0x101192d5 */
            ii(0x1011_9298, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_929c, 3); add(edx, 0x3);                          /* add edx, 0x3 */
            ii(0x1011_929f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_92a1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_92a4, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_92a7, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1011_92a9, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1011_92ac, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_92af, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1011_92b3, 5); cmp(eax, 0x7fff);                       /* cmp eax, 0x7fff */
            ii(0x1011_92b8, 2); if(jzd(0x1011_92d0, 0x16)) goto l_0x1011_92d0; /* jz 0x101192d0 */
            ii(0x1011_92ba, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_92be, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1011_92c3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_92c5, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_92c8, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_92ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_92cd, 3); mov(memb_a32[ds, eax + 0x64], dl);      /* mov [eax+0x64], dl */
        l_0x1011_92d0:
            ii(0x1011_92d0, 5); jmpd(0x1011_9425, 0x150); goto l_0x1011_9425; /* jmp 0x10119425 */
        l_0x1011_92d5:
            ii(0x1011_92d5, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_92d9, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1011_92dd, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1011_92e0, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1011_92e4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_92e6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_92e9, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_92eb, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1011_92ef, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_92f1, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1011_92f4, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1011_92f8, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1011_92fc, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1011_92ff, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1011_9303, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_9305, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_9308, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_930a, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_930e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_9310, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1011_9313, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1011_9316, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1011_9319, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_931c, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1011_931f, 3); sub(eax, memd_a32[ss, ebp - 0x1c]);     /* sub eax, [ebp-0x1c] */
            ii(0x1011_9322, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1011_9325, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1011_9329, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_932d, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1011_9330, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1011_9332, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1011_9336, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1011_933a, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1011_933d, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1011_933f, 3); mov(memd_a32[ss, ebp - 0x3c], ebx);     /* mov [ebp-0x3c], ebx */
            ii(0x1011_9342, 3); fild(memd_a32[ss, ebp - 0x3c]);         /* fild dword [ebp-0x3c] */
            ii(0x1011_9345, 5); calld(Definitions.sys_sqrt, 0x4ccfc);   /* call 0x10166046 */
            ii(0x1011_934a, 6); fmul(memq_a32[ds, 0x101a_7c9a]);        /* fmul qword [0x101a7c9a] */
            ii(0x1011_9350, 6); fadd(memq_a32[ds, 0x101a_7ca2]);        /* fadd qword [0x101a7ca2] */
            ii(0x1011_9356, 5); calld(Definitions.sys_round, 0x4cd23);  /* call 0x1016607e */
            ii(0x1011_935b, 3); fistp(memd_a32[ss, ebp - 0x3c]);        /* fistp dword [ebp-0x3c] */
            ii(0x1011_935e, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1011_9361, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_9364, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9367, 4); cmp(ax, memw_a32[ss, ebp - 0x28]);      /* cmp ax, [ebp-0x28] */
            ii(0x1011_936b, 2); if(jled(0x1011_9373, 0x6)) goto l_0x1011_9373; /* jle 0x10119373 */
            ii(0x1011_936d, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1011_9370, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1011_9373:
            ii(0x1011_9373, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1011_9377, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_9379, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_937c, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_937f, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1011_9381, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1011_9384, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_9387, 3); mov(al, memb_a32[ss, ebp - 0x28]);      /* mov al, [ebp-0x28] */
            ii(0x1011_938a, 3); sub(al, memb_a32[ss, ebp - 0x8]);       /* sub al, [ebp-0x8] */
            ii(0x1011_938d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_9390, 3); mov(memb_a32[ds, edx + 0x64], al);      /* mov [edx+0x64], al */
            ii(0x1011_9393, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_9396, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_9398, 3); mov(al, memb_a32[ds, edx + 0x64]);      /* mov al, [edx+0x64] */
            ii(0x1011_939b, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_939e, 2); if(jld(0x1011_93a7, 0x7)) goto l_0x1011_93a7; /* jl 0x101193a7 */
            ii(0x1011_93a0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_93a3, 4); mov(memb_a32[ds, eax + 0x64], 0x3);     /* mov byte [eax+0x64], 0x3 */
        l_0x1011_93a7:
            ii(0x1011_93a7, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_93ab, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_93ad, 2); if(jzd(0x1011_93b7, 0x8)) goto l_0x1011_93b7; /* jz 0x101193b7 */
            ii(0x1011_93af, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_93b3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_93b5, 2); if(jnzd(0x1011_9425, 0x6e)) goto l_0x1011_9425; /* jnz 0x10119425 */
        l_0x1011_93b7:
            ii(0x1011_93b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_93ba, 4); mov(memb_a32[ds, eax + 0x4e], 0);       /* mov byte [eax+0x4e], 0x0 */
            ii(0x1011_93be, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_93c1, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1011_93c4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_93c7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_93ca, 3); sub(eax, memd_a32[ss, ebp - 0x1c]);     /* sub eax, [ebp-0x1c] */
            ii(0x1011_93cd, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1011_93d0, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_93d4, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1011_93d8, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1011_93db, 4); movsx(ebx, memw_a32[ss, ebp - 0x24]);   /* movsx ebx, word [ebp-0x24] */
            ii(0x1011_93df, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1011_93e3, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1011_93e6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_93e8, 3); mov(memd_a32[ss, ebp - 0x3c], edx);     /* mov [ebp-0x3c], edx */
            ii(0x1011_93eb, 3); fild(memd_a32[ss, ebp - 0x3c]);         /* fild dword [ebp-0x3c] */
            ii(0x1011_93ee, 5); calld(Definitions.sys_sqrt, 0x4cc53);   /* call 0x10166046 */
            ii(0x1011_93f3, 6); fmul(memq_a32[ds, 0x101a_7caa]);        /* fmul qword [0x101a7caa] */
            ii(0x1011_93f9, 6); fadd(memq_a32[ds, 0x101a_7cb2]);        /* fadd qword [0x101a7cb2] */
            ii(0x1011_93ff, 5); calld(Definitions.sys_round, 0x4cc7a);  /* call 0x1016607e */
            ii(0x1011_9404, 3); fistp(memd_a32[ss, ebp - 0x3c]);        /* fistp dword [ebp-0x3c] */
            ii(0x1011_9407, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1011_940a, 4); mov(memw_a32[ss, ebp - 0x8], ax);       /* mov [ebp-0x8], ax */
            ii(0x1011_940e, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_9412, 3); add(edx, 0x3);                          /* add edx, 0x3 */
            ii(0x1011_9415, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_9417, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_941a, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_941d, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1011_941f, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1011_9422, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1011_9425:
            ii(0x1011_9425, 7); cmp(memb_a32[ds, 0x101c_37ca], 0);      /* cmp byte [0x101c37ca], 0x0 */
            ii(0x1011_942c, 2); if(jzd(0x1011_9437, 0x9)) goto l_0x1011_9437; /* jz 0x10119437 */
            ii(0x1011_942e, 7); mov(memd_a32[ss, ebp - 0x4c], 0x2);     /* mov dword [ebp-0x4c], 0x2 */
            ii(0x1011_9435, 2); jmpd(0x1011_943e, 0x7); goto l_0x1011_943e; /* jmp 0x1011943e */
        l_0x1011_9437:
            ii(0x1011_9437, 7); mov(memd_a32[ss, ebp - 0x4c], 0x4);     /* mov dword [ebp-0x4c], 0x4 */
        l_0x1011_943e:
            ii(0x1011_943e, 3); mov(al, memb_a32[ss, ebp - 0x4c]);      /* mov al, [ebp-0x4c] */
            ii(0x1011_9441, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_9444, 3); mov(memb_a32[ds, edx + 0x2a], al);      /* mov [edx+0x2a], al */
            ii(0x1011_9447, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_944a, 3); mov(al, memb_a32[ds, eax + 0x2a]);      /* mov al, [eax+0x2a] */
            ii(0x1011_944d, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_944f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_9452, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1011_9455, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_9458, 5); mov(eax, 0x2d);                         /* mov eax, 0x2d */
            ii(0x1011_945d, 5); calld(Definitions.sys_new, 0x4c99e);    /* call 0x10165e00 */
            ii(0x1011_9462, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1011_9465, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1011_9468, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1011_946b, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1011_946f, 2); if(jzd(0x1011_949e, 0x2d)) goto l_0x1011_949e; /* jz 0x1011949e */
            ii(0x1011_9471, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_9475, 1); pushd(eax);                             /* push eax */
            ii(0x1011_9476, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1011_947a, 1); pushd(eax);                             /* push eax */
            ii(0x1011_947b, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_947f, 1); pushd(eax);                             /* push eax */
            ii(0x1011_9480, 4); movsx(ecx, memw_a32[ss, ebp - 0x24]);   /* movsx ecx, word [ebp-0x24] */
            ii(0x1011_9484, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1011_9488, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_948b, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1011_948e, 5); calld(0x1011_833b, -0x1158);            /* call 0x1011833b */
            ii(0x1011_9493, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1011_9496, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1011_9499, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1011_949c, 2); jmpd(0x1011_94a4, 0x6); goto l_0x1011_94a4; /* jmp 0x101194a4 */
        l_0x1011_949e:
            ii(0x1011_949e, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1011_94a1, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
        l_0x1011_94a4:
            ii(0x1011_94a4, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1011_94a7, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1011_94aa:
            ii(0x1011_94aa, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1011_94ad, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_94af, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_94b0, 1); popd(edi);                              /* pop edi */
            ii(0x1011_94b1, 1); popd(esi);                              /* pop esi */
            ii(0x1011_94b2, 1); popd(edx);                              /* pop edx */
            ii(0x1011_94b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_94b4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_94b5, 1); retd(); return;                         /* ret */
        }
    }
}
